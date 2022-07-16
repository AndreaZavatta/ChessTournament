using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Context.Data;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Agreement.JPake;
using Org.BouncyCastle.Math.EC.Rfc8032;

namespace WindowsFormApp
{
    public partial class FormHomePage : Form
    {
        private string _connectionString;

        public FormHomePage()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            InitializeComponent();
        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {

            SetVisibility(sender);
            using (MyDbContext ctx = new MyDbContext(_connectionString))
            {
                List<Torneo> listTornei = ctx.Tornei.ToList();
                listTornei.Insert(0, new Torneo { Nome = "", Codice = 0 });
                cbTorneo.ValueMember = "Codice";
                cbTorneo.DisplayMember = "Nome";
                cbTorneo.DataSource = listTornei;
            }
        }

        private void SetVisibility(object sender)
        {
            if (LoggedUser.Tipo != Persona.TipoUtente.Organizzatore)
            {
                btnCreaTorneo.Visible = false;
            }
            else
            {
                DataGridView dgv = ((FormHomePage)sender).dgvTornei;
                dgv.Columns["Elimina"]!.Visible = true;
            }

            if (LoggedUser.Tipo == Persona.TipoUtente.Giocatore)
            {
                DataGridView dgv = ((FormHomePage)sender).dgvTornei;
                dgv.Columns["Partecipa"]!.Visible = true;
            }
        }

        private void cbTorneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        public void UpdateTable()
        {
            using (MyDbContext ctx = new MyDbContext(_connectionString))
            {
                var list = ctx.Edizioni.Where(q => q.CodiceTorneo.Equals(cbTorneo.SelectedValue))
                    .Select(q => new
                    {
                        Codice = q.Codice, Descrizione = q.Descrizione, NumEdizione = q.NumEdizione,
                        DataInizio = q.DataInizio, DataFine = q.DataFine
                    }).ToList();
                dgvTornei.DataSource = list;
            }
        }


        private void dgvTornei_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int codice = (int)dgv.Rows[e.RowIndex].Cells[dgv.Columns["Codice"].Index].Value;
            if (IsColumnDetails(e, dgv))
            {
                new FormDettaglioEdzione(codice).ShowDialog();
            }
            else if (IsColumnElimina(e, dgv))
            {
                DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare questa edizione?", "Eliminazione", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    EliminazioneEdizione(codice);
                    MessageBox.Show("Salvataggio avvenuto correttamente");
                }

            }

            else if (IsColumnPartecipa(e, dgv))
            {
                IscrizioneEdizione(codice);
            }
        }

        private void EliminazioneEdizione(int codice)
        {
            using (MyDbContext ctx = new MyDbContext(_connectionString))
            {
                Edizione edToDelete = ctx.Edizioni.FirstOrDefault(q => q.Codice == codice);
                if (edToDelete != null)
                {
                    edToDelete.CodiceVincitore = null;
                    ctx.SaveChanges();
                    var list = ctx.Iscritti.Where(q => q.CodiceEdizione == codice);
                    ctx.Iscritti.RemoveRange(list);
                    ctx.Edizioni.Remove(edToDelete);
                    ctx.SaveChanges();
                    UpdateTable();
                }
            }
        }

        private void IscrizioneEdizione(int codice)
        {
            DialogResult dialogResult = MessageBox.Show("Confermi l'iscrizione?", "Iscrizione", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (MyDbContext ctx = new MyDbContext(_connectionString))
                {
                    Edizione edizione = ctx.Edizioni
                        .Include(q => q.Torneo)
                        .FirstOrDefault(q => q.Codice == codice);

                    if (edizione == null)
                    {
                        MessageBox.Show("Edizione non trovata");
                        return;
                    }

                    int numIscritti = ctx.Iscritti.Select(q => q.CodiceEdizione == codice).Count();
                    if (numIscritti >= edizione.Torneo.MaxPartecipanti)
                    {
                        MessageBox.Show(
                            "Non puoi partecipare al torneo, massimo numero di partecipanti raggiunto!");
                        return;
                    }

                    if (LoggedUser.Tipo != Persona.TipoUtente.Giocatore)
                    {
                        MessageBox.Show("Operazione riservata ai giocatori");
                        return;
                    }

                    Giocatore giocatore = ctx.Giocatori.FirstOrDefault(q => q.CodicePersona == LoggedUser.Codice);
                    if (giocatore == null)
                    {
                        MessageBox.Show("Giocatore non trovato!");
                        return;
                    }

                    if (ctx.Iscritti.Any(q => q.CodiceEdizione == codice && q.CodiceGiocatore == giocatore.Codice))
                    {
                        MessageBox.Show("Sei già iscritto a questa edizione");
                        return;
                    }

                    if (giocatore.Rating > edizione.Torneo.RatingMassimo ||
                        giocatore.Rating < edizione.Torneo.RatingMinimo)
                    {
                        MessageBox.Show("Non puoi partecipare al torneo, il tuo rating non lo permette!\n" +
                                            $"Rating massimo: {edizione.Torneo.RatingMassimo}\n" +
                                            $"Rating minimo: {edizione.Torneo.RatingMinimo}\n" +
                                            $"Il tuo rating: {giocatore.Rating}");
                        return;
                    }

                    ctx.Iscritti.Add(new Iscritto
                    {
                        CodiceGiocatore = giocatore.Codice,
                        CodiceEdizione = codice,
                        Data = DateTime.Now
                    });
                    ctx.SaveChanges();
                }
            }
        }

        private bool IsColumnDetails(DataGridViewCellEventArgs e, DataGridView dgv)
        {
            return e.ColumnIndex == dgv.Columns["Details"].Index && e.RowIndex >= 0;
        }

        private bool IsColumnPartecipa(DataGridViewCellEventArgs e, DataGridView dgv)
        {
            return e.ColumnIndex == dgv.Columns["Partecipa"].Index && e.RowIndex >= 0;
        }

        private bool IsColumnElimina(DataGridViewCellEventArgs e, DataGridView dgv)
        {
            return e.ColumnIndex == dgv.Columns["Elimina"].Index && e.RowIndex >= 0;
        }

        private void btnCreaTorneo_Click(object sender, EventArgs e)
        {
            var form = new FormCreaTorneo();
            form.Tag = this;
            form.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabStatistica1")
            {
                tbStatistica1.Text = "ISCRITTI ORDINATI PER NUMERO DI PARTECIPAZIONI";
                using (MyDbContext ctx = new MyDbContext(_connectionString))
                {
                    var iscrizioni = ctx.Iscritti
                        .GroupBy(q => q.CodiceGiocatore)
                        .Select(q => new
                        {
                            CodiceGiocatore = q.Key,
                            numero = q.Count()
                        });

                    var query =
                        from i in iscrizioni
                        join g in ctx.Giocatori on i.CodiceGiocatore equals g.Codice
                        join p in ctx.Persone on g.CodicePersona equals p.Codice
                        orderby i.numero descending
                        select new { Nome = p.Nome, Cognome = p.Cognome, Partecipazioni = i.numero };

                    dgvStats1.DataSource = query.ToList();
                }

            }
            else if (tabControl1.SelectedTab.Name == "tabStatistica2")
            {
                tbStatistica2.Text = "edizioni in cui ha partecipato un giocatore evidenziando quelle in cui ha vinto".ToUpper();


                using (MyDbContext ctx = new MyDbContext(_connectionString))
                {
                    var listGiocatori = ctx.Giocatori
                        .Include(q => q.Persona)
                        .Select(q => new
                        {
                            Codice = q.Codice,
                            Nome = $"{q.Persona.Nome} {q.Persona.Cognome}"
                        }).ToList();
                    listGiocatori.Insert(0, new {Codice = 0, Nome = "" });
                    cbGiocatore.ValueMember = "Codice";
                    cbGiocatore.DisplayMember = "Nome";
                    cbGiocatore.DataSource = listGiocatori;
                }
            }
            else if (tabControl1.SelectedTab.Name == "tabStatistica3")
            {
                tbStatistica3.Text = "visualizzare tutti i giocatori che ha allenato un allenatore".ToUpper();


                using (MyDbContext ctx = new MyDbContext(_connectionString))
                {
                    var listAllenatori = ctx.Allenatori
                        .Include(q => q.Persona)
                        .Select(q => new
                        {
                            Codice = q.Codice,
                            Nome = $"{q.Persona.Nome} {q.Persona.Cognome}"
                        }).ToList();
                    listAllenatori.Insert(0, new { Codice = 0, Nome = "" });
                    cbAllenatore.ValueMember = "Codice";
                    cbAllenatore.DisplayMember = "Nome";
                    cbAllenatore.DataSource = listAllenatori;
                }
            }
            else if (tabControl1.SelectedTab.Name == "tabClassifica")
            {
                tbClassifica.Text = "Classifica dei giocatori in base al rating".ToUpper();
                using (MyDbContext ctx = new MyDbContext(_connectionString))
                {
                        var query =
                            from g in ctx.Giocatori
                            join p in ctx.Persone on g.CodicePersona equals p.Codice
                            orderby g.Rating descending
                            select new { Nome = p.Nome, Cognome = p.Cognome, Rating = g.Rating};
                        dgvClassifica.DataSource = query.ToList();
                }

            }
            /*  select Nome, Cognome, rating
                from giocatore g
                inner join persona p on g.CodicePersona = p.Codice
                order by rating desc
            */
        }

        private void cbGiocatore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cbGiocatore.SelectedValue != 0)
            {
                using (MyDbContext ctx = new MyDbContext(_connectionString))
                {
                    var query =
                        from i in ctx.Iscritti
                        join g in ctx.Giocatori on i.CodiceGiocatore equals g.Codice
                        join ed in ctx.Edizioni on i.CodiceEdizione equals ed.Codice
                        join e2 in ctx.Edizioni on i.Codice equals e2.CodiceVincitore into edizione
                        from e2 in edizione.DefaultIfEmpty()
                        where g.Codice == (int)cbGiocatore.SelectedValue
                        select new { Edizione = ed.Descrizione, Vincitore = (e2 == null ? "" : "Vincitore") };

                    dgvStatistica2.DataSource = query.ToList();
                }
            }
            else
            {
                dgvStatistica2.DataSource = null;
            }
        }

        private void cbStatistica3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cbAllenatore.SelectedValue != 0)
            {
                using (MyDbContext ctx = new MyDbContext(_connectionString))
                {
                    var query =
                        (from a in ctx.Allenamenti
                            join g in ctx.Giocatori on a.CodiceGiocatore equals g.Codice
                            join p in ctx.Persone on g.CodicePersona equals p.Codice
                            where a.CodiceAllenatore == (int)cbAllenatore.SelectedValue
                            select new
                            {
                                Nome = p.Nome,
                                Cognome = p.Cognome
                            }).Distinct();
                    dgvStatistica3.DataSource = query.ToList();
                }
            }
            else
            {
                dgvStatistica3.DataSource = null;
            }
        }



    }
}

