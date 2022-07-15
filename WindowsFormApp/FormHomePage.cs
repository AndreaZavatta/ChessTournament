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


        private void dgvTornei_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (isColumnDetails(e, dgv))
            {
                int codice = (int)dgv.Rows[e.RowIndex].Cells[dgv.Columns["Codice"].Index].Value;
                new FormDettaglioEdzione(codice).ShowDialog();
            }
            else if (isColumnPartecipa(e, dgv))
            {
                int codice = (int)dgv.Rows[e.RowIndex].Cells[dgv.Columns["Codice"].Index].Value;
                using (MyDbContext ctx = new MyDbContext(_connectionString))
                {
                    int id = ctx.Edizioni.Find(codice).CodiceTorneo;
                    int maxPartecipanti = ctx.Tornei.Find(id).MaxPartecipanti;
                    int maxRating = ctx.Tornei.Find(id).RatingMassimo;
                    int minRating = ctx.Tornei.Find(id).RatingMinimo;
                    int numIscritti = ctx.Iscritti.Select(q => q.CodiceEdizione == codice).ToList().Count;
                    if (numIscritti >= maxPartecipanti)
                    {
                        MessageBox.Show("Non puoi partecipare al torneo, massimo numero di partecipanti raggiunto!");
                    }
                    else if (LoggedUser.Tipo == Persona.TipoUtente.Giocatore)
                    {
                        int? codPersona = ctx.Persone?.FirstOrDefault(q => q.Email.ToLower() == LoggedUser.Email.ToLower())?.Codice;
                        if (codPersona != null)
                        {
                            int? codGiocatore = (ctx.Giocatori?.FirstOrDefault(q => q.CodicePersona == codPersona)?.Codice);
                            int? rating = (ctx.Giocatori?.Find(codGiocatore)?.Rating);
                            if (rating != null)
                            {
                                if (rating > maxRating || rating < minRating)
                                {
                                    MessageBox.Show("Non puoi partecipare al torneo, il tuo rating non lo permette!");
                                }
                                else
                                {
                                    ctx.Iscritti.Add(new Iscritto
                                    {
                                        CodiceGiocatore = codGiocatore,
                                        CodiceEdizione = codice,
                                        Data = DateTime.Now
                                    });
                                }
                            }
                        }
                    }
                }
                }
            }

        private static bool isColumnDetails(DataGridViewCellEventArgs e, DataGridView dgv)
        {
            return e.ColumnIndex == dgv.Columns["Details"].Index && e.RowIndex >= 0;
        }
        private static bool isColumnPartecipa(DataGridViewCellEventArgs e, DataGridView dgv)
        {
            return e.ColumnIndex == dgv.Columns["Partecipa"].Index && e.RowIndex >= 0;
        }

        private void btnCreaTorneo_Click(object sender, EventArgs e)
        {
            var form = new FormCreaTorneo();
            form.Tag = this;
            form.ShowDialog();
        }

    }
}
