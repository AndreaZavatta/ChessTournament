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

namespace WindowsFormApp
{
    public partial class FormDettaglioEdzione : Form
    {
        private readonly string _connectionString;

        public int Id { get; set; }

        public FormDettaglioEdzione(int id): this()
        {
            Id = id;
        }

        public FormDettaglioEdzione()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            InitializeComponent();
        }

        private void FormDettaglioEdzione_Load(object sender, EventArgs e)
        {
            using (MyDbContext ctx = new MyDbContext(_connectionString))
            {
                Edizione edizione = ctx.Edizioni
                    .Include(q => q.Vincitore)
                    .Include(q => q.Vincitore.Giocatore)
                    .Include(q => q.Vincitore.Giocatore.Persona)
                    .Include(q => q.Organizzatore)
                    .Include(q => q.Organizzatore.Persona)
                    .Include(q => q.Luogo)
                    .FirstOrDefault(q => q.Codice == Id);
                if (edizione != null)
                {
                    txtPremio.Text = edizione.PremioVincita.ToString();
                    txtAnno.Text = edizione.Anno.ToString();
                    txtDataFine.Text = edizione.DataFine?.ToShortDateString();
                    txtDataInizio.Text = edizione.DataInizio?.ToShortDateString();
                    txtDescrizione.Text = edizione.Descrizione;
                    txtLuogo.Text = edizione.Luogo?.Nome;
                    txtNumeroEdizione.Text = edizione.NumEdizione.ToString();
                    txtOrganizzatore.Text = $@"{edizione.Organizzatore?.Persona?.Nome} {edizione.Organizzatore?.Persona?.Cognome}";
                    txtPremio.Text = edizione.PremioVincita.ToString();
                    txtVincitore.Text = $@"{edizione.Vincitore?.Giocatore?.Persona?.Nome} {edizione.Vincitore?.Giocatore?.Persona?.Cognome}";
                }
            }
        }
    }
}
