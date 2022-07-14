using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using Castle.Core.Internal;
using Context.Data;
using Microsoft.EntityFrameworkCore;

namespace WindowsFormApp
{
    public partial class FormCreaTorneo : Form
    {
        private string _connectionString;

        public FormCreaTorneo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            InitializeComponent();
        }


        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.IsNullOrEmpty())
            {
                MessageBox.Show("inserisci un nome!");
                return;
            }


            using (MyDbContext ctx = new MyDbContext(_connectionString))
            {
                Torneo torneo = null;
                if ((int)cbTorneo.SelectedValue != 0)
                {
                    torneo = ctx.Tornei.Find(cbTorneo.SelectedValue);
                }
                else
                {
                    torneo = new Torneo();
                    ctx.Tornei.Add(torneo);
                }

                torneo.Nome = txtNome.Text;
                torneo.RatingMassimo = Convert.ToInt32(txtRatingMassimo.Text);
                torneo.RatingMinimo = Convert.ToInt32(txtRatingMinimo.Text);
                torneo.MaxPartecipanti = Convert.ToInt32(txtMaxPartecipanti.Text);
                torneo.QuotaIscrizione = Convert.ToInt32(txtQuota.Text);

                Edizione edizione = new Edizione
                {
                    DataInizio = dtpDataInizio.Value,
                    DataFine = dtpDataFine.Value,
                    Anno = Convert.ToInt32(txtAnno.Text),
                    Descrizione = txtDescrizione.Text,
                    NumEdizione = Convert.ToInt32(txtNumeroEdizione.Text),
                    PremioVincita = Convert.ToInt32(txtPremio.Text),
                    CodiceTorneo = torneo.Codice,
                    CodiceLuogo = (int?)cbLuogo.SelectedValue == 0 ? (int?)null : (int?)cbLuogo.SelectedValue,
                    CodiceOrganizzatore = Convert.ToInt32(cbOrganizzatore.SelectedValue),
                    Torneo = torneo
                    
                };
                ctx.Edizioni.Add(edizione);
                ctx.SaveChanges();
                MessageBox.Show("Salvataggio avvenuto correttamente");
                ((FormHomePage)this.Tag).UpdateTable();
                this.Close();
            }
        }






        private void FormCreaTorneo_Load(object sender, EventArgs e)
        {
            using (MyDbContext ctx = new MyDbContext(_connectionString))
            {
                cbOrganizzatore.DataSource = ctx.Organizzatori.Include(q => q.Persona)
                    .Select(q => new { Codice = q.Codice, Nome = q.Persona.Nome }).ToList();

                cbOrganizzatore.ValueMember = "Codice";
                cbOrganizzatore.DisplayMember = "Nome";


                List<Luogo> listLuoghi = ctx.Luoghi.ToList();
                listLuoghi.Insert(0, new Luogo { Nome = "", Codice = 0 });
                cbLuogo.DataSource = listLuoghi;
                cbLuogo.ValueMember = "Codice";
                cbLuogo.DisplayMember = "Nome";

                List<Torneo> listTornei = ctx.Tornei.ToList();
                listTornei.Insert(0, new Torneo { Nome = "", Codice = 0 });
                cbTorneo.DataSource = listTornei;
                cbTorneo.ValueMember = "Codice";
                cbTorneo.DisplayMember = "Nome";

            }
        }

        private void cbTorneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MyDbContext ctx = new MyDbContext(_connectionString))
            {
                if (cbTorneo.SelectedValue is int)
                {
                    Torneo torneo = ctx.Tornei.Find((int)cbTorneo.SelectedValue);
                    if (torneo != null)
                    {
                        txtQuota.Text = torneo.QuotaIscrizione.ToString();
                        txtNome.Text = torneo.Nome;
                        txtRatingMinimo.Text = torneo.RatingMinimo.ToString();
                        txtRatingMassimo.Text = torneo.RatingMassimo.ToString();
                        txtMaxPartecipanti.Text = torneo.MaxPartecipanti.ToString();
                    }
                    else
                    {
                        txtQuota.Text = "";
                        txtNome.Text = "";
                        txtRatingMinimo.Text = "";
                        txtRatingMassimo.Text = "";
                        txtMaxPartecipanti.Text = "";
                    }
                }
            }
        }

    }
}
