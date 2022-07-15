﻿using System;
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
            int codice = (int)dgv.Rows[e.RowIndex].Cells[dgv.Columns["Codice"].Index].Value;
            if (IsColumnDetails(e, dgv))
            {
                new FormDettaglioEdzione(codice).ShowDialog();
            }
            else if (IsColumnElimina(e, dgv))
            {
                EliminazioneEdizione(codice);
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
    }
}

