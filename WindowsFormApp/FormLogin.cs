using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Castle.Core.Internal;
using Context.Data;
using System.Security.Cryptography;


namespace WindowsFormApp
{


    public partial class FormLogin
    {
        private readonly string _connectionString;
        public FormLogin()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var err = GetErrorMessage();
            if (!err.IsNullOrEmpty())
            {
                MessageBox.Show(err);
            }
            else
            {
                Persona persona = GetUser(txtEmail.Text, txtPassword.Text);
                if ( persona is null)
                {
                    MessageBox.Show("Credenziali non valide");
                }
                else
                {
                    saveLoggedUser(persona);
                    SwitchPage(persona);
                }
            }
        }

        private Form GetPageFromUserType(Persona person)
        {
            if (person.Tipo.Equals(Persona.TipoUtente.Organizzatore))
            {
                return new FormOrganizzatore();
            }
            else if (person.Tipo.Equals(Persona.TipoUtente.Allenatore))
            {
                return new FormAllenatore();
            }
            else
            {
                return new FormGiocatore();
            }
        }

        private void SwitchPage(Persona persona)
        {
            this.Hide();
            GetPageFromUserType(persona).ShowDialog();
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


        private String GetErrorMessage()
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

        private void btnBack_Click(object sender, EventArgs e)
        {
           this.Hide();
           new FormMain().ShowDialog();
           this.Close();
        }
    }
}
