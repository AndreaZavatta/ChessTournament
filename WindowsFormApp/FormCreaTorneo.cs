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
    public partial class FormCreaTorneo : Form
    {
        private string _connectionString;
        public FormCreaTorneo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void btnCreaTorneo_Click(object sender, EventArgs e)
        {
            using (MyDbContext ctx = new MyDbContext(_connectionString))
            {
                Torneo torneo = CheckExistingTournament();
                if (torneo != null)
                {
                    ctx.Tornei.Add(torneo);
                }

                ctx.Edizioni.Add(new Edizione
                {
                    DataInizio = dtpDataInizio.Value,
                    DataFine = dtpDataFine.Value,
                    Anno = Convert.ToInt32(txtAnno.Text),
                    Descrizione = txtDescrizione.Text,
                    NumEdizione = Convert.ToInt32(txtNumeroEdizione.Text)
                });
            }

        }

        private Torneo CheckExistingTournament()
        {
            using (MyDbContext ctx = new MyDbContext(_connectionString))
            {
                return ctx.Tornei.FirstOrDefault(q => q.Nome.ToLower().Equals(txtNome.Text.ToLower()));
            }
        }





        private void FormCreaTorneo_Load(object sender, EventArgs e)
        {
            using (MyDbContext ctx = new MyDbContext(_connectionString))
            {
                cbOrganizzatore.DataSource = ctx.Organizzatori.Select(q => q.Persona).ToList();
                cbOrganizzatore.ValueMember = "Codice";
                cbOrganizzatore.DisplayMember = "Nome";
                cbVincitore.DataSource = ctx.Giocatori.Select(q => q.Persona).ToList();
                cbVincitore.ValueMember = "Codice";
                cbVincitore.DisplayMember = "Nome";
                cbLuogo.DataSource = ctx.Luoghi.ToList();
                cbLuogo.ValueMember = "Codice";
                cbLuogo.DisplayMember = "Nome";
            }
        }
    }
}
