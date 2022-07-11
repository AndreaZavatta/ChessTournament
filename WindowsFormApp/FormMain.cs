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
    public partial class FormMain : Form
    {
        private readonly string _connectionString;
        public FormMain()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var err = GetErrorMessageLogin();
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err);
            }
            else
            {
                Persona persona = GetUser(txtEmail.Text, txtPassword.Text);
                if (persona is null)
                {
                    MessageBox.Show("Credenziali non valide");
                }
                else
                {
                    saveLoggedUser(persona);
                    SwitchPage(persona.Tipo);
                }
            }
        }

        private Form GetPageFromUserType(Persona.TipoUtente tipo)
        {
            if (tipo.Equals(Persona.TipoUtente.Organizzatore))
            {
                return new FormOrganizzatore();
            }
            else if (tipo.Equals(Persona.TipoUtente.Allenatore))
            {
                return new FormAllenatore();
            }
            else
            {
                return new FormGiocatore();
            }
        }

        private void SwitchPage(Persona.TipoUtente tipo)
        {
            this.Hide();
            GetPageFromUserType(tipo).ShowDialog();
            this.Close();
        }

        private void saveLoggedUser(Persona persona)
        {
            LoggedUser.Email = txtEmail.Text;
            LoggedUser.Nome = persona.Nome;
            LoggedUser.Cognome = persona.Cognome;
            LoggedUser.Tipo = persona.Tipo;
        }

        private Persona GetUser(string email, string password)
        {
            using (MyDbContext ctx = new MyDbContext(_connectionString))
            {
                string sha256Pwd = Converter.ComputeSha256Hash(password);
                return ctx.Persone.FirstOrDefault(q => q.Email.Equals(email) && q.Password.Equals(sha256Pwd));
            }
        }


        private String GetErrorMessageLogin()
        {
            StringBuilder err = new StringBuilder();

            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                err.Append($"inserire un email{Environment.NewLine}");
            }

            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                err.Append($"inserire una password{Environment.NewLine}");
            }
            return err.ToString();
        }

        private void SavePlayer()
        {
            using (MyDbContext ctx = new MyDbContext(_connectionString))
            {
                Persona person = GetNewPerson(Persona.TipoUtente.Giocatore);
                ctx.Persone.Add(person);
                Giocatore player = new Giocatore()
                {
                    Persona = person,
                    Federazione = txtFederazione.Text,
                    Rating = string.IsNullOrEmpty(txtRating.Text) ? (int?)null : Convert.ToInt32(txtRating.Text),
                };
                ctx.Add(player);
                ctx.SaveChanges();
            }
        }
        private void SaveOrganizer()
        {
            using (MyDbContext ctx = new MyDbContext(_connectionString))
            {
                Persona person = GetNewPerson(Persona.TipoUtente.Organizzatore);
                ctx.Persone.Add(person);
                Organizzatore organizer = new Organizzatore()
                {
                    Persona = person
                };
                ctx.Add(organizer);
                ctx.SaveChanges();
            }
        }

        private void SaveCoach()
        {
            using (MyDbContext ctx = new MyDbContext(_connectionString))
            {
                Persona person = GetNewPerson(Persona.TipoUtente.Allenatore);
                ctx.Persone.Add(person);
                Allenatore coach = new Allenatore
                {
                    Persona = person,
                    Federazione = txtFederazione.Text,
                };
                ctx.Allenatori.Add(coach);
                ctx.SaveChanges();
            }
        }

        private Persona GetNewPerson(Persona.TipoUtente tipo)
        {
            return new Persona
            {
                Nome = txtNome.Text,
                Cognome = txtCognome.Text,
                Email = txtEmail.Text,
                DataNascita = dateTimePicker1.Value,
                Genere = cmbGenere.Text.Equals("Maschio") ? 0 : 1,
                Password = Converter.ComputeSha256Hash(txtPassword.Text),
                Telefono = txtTelefono.Text,
                Tipo = tipo
            };
        }

        private void SaveUser()
        {
            try
            {
                if (cmbTipologia.Text.Equals("Giocatore"))
                {
                    SavePlayer();
                }
                else if (cmbTipologia.Text.Equals("Organizzatore"))
                {
                    SaveOrganizer();
                }
                else
                {
                    SaveCoach();
                }

                MessageBox.Show("Registrazione completata con successo");
                tabControl1.SelectedTab = tabLogin;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel salvataggio dell'utente");
            }
        }

        private bool CheckExtistingUser(string email)
        {
            using (MyDbContext ctx = new MyDbContext(_connectionString))
            {
                return ctx.Persone.FirstOrDefault(q => q.Email.Equals(email)) != null;
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            var error = GetErrorMessageRegistrazione();
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Attenzione!");
            }
            else
            {
                if (!CheckExtistingUser(txtEmailReg.Text))
                {
                    SaveUser();
                }
                else
                {
                    MessageBox.Show("Utente già esistente");
                }

            }
        }


        private String GetErrorMessageRegistrazione()
        {
            StringBuilder err = new StringBuilder();
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                err.Append($"Inserire un nome{Environment.NewLine}");
            }

            if (String.IsNullOrEmpty(txtCognome.Text))
            {
                err.Append($"Inserire un cognome{Environment.NewLine}");
            }

            if (String.IsNullOrEmpty(txtEmailReg.Text))
            {
                err.Append($"Inserire un email{Environment.NewLine}");
            }

            if (String.IsNullOrEmpty(txtPasswordReg.Text))
            {
                err.Append($"Inserire una password{Environment.NewLine}");
            }

            if (cmbGenere.Text.Equals("Genere"))
            {
                err.Append($"Inserire un genere{Environment.NewLine}");
            }

            if (cmbTipologia.Text.Equals("Tipologia"))
            {
                err.Append($"Inserire una tipologia{Environment.NewLine}");
            }

            return err.ToString();
        }

        private void cmbTipologia_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTipologia.Text)
            {
                case "Allenatore":
                    lblRating.Visible = false;
                    txtRating.Visible = false;
                    lblFederazione.Visible = true;
                    txtFederazione.Visible = true;
                    break;
                case "Organizzatore":
                    lblFederazione.Visible = false;
                    txtFederazione.Visible = false;
                    lblRating.Visible = false;
                    txtRating.Visible = false;
                    break;
                case "Giocatore":
                    lblFederazione.Visible = true;
                    txtFederazione.Visible = true;
                    lblRating.Visible = true;
                    txtRating.Visible = true;
                    break;
            }
        }
    }
}
