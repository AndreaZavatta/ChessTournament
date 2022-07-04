using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Context.Data;
using Microsoft.EntityFrameworkCore;

namespace WindowsFormApp
{
    public partial class Form1 : Form
    {
        private static string connectionString;

        public Form1()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MyDbContext ctx = new MyDbContext(connectionString))
            {
                //dataGridView1.DataSource = ctx.Utente
                //    .Select(q => new { Id = q.id, Nome = q.Nome, Cognome = q.Cognome, Tipo = q.Tipo, Localita = q.Localita.Nome }).ToList();
            }
        }


        private void LeggeLista()
        {
            using (MyDbContext ctx = new MyDbContext(connectionString))
            {
                //var lista = ctx.Prodotto.Where(q => q.Descrizione.Substring(0, 1) == "r").ToList();
            }
        }

        private void LeggeUnElemento()
        {
            using (MyDbContext ctx = new MyDbContext(connectionString))
            {
                //var item = ctx.Prodotto.Where(q => q.Descrizione.Substring(0, 1) == "r").FirstOrDefault();
            }
        }

        private void LeggeUtente()
        {
            using (MyDbContext ctx = new MyDbContext(connectionString))
            {
                //Persona utente = ctx.Utente.Include(q => q.Localita).Where(q => q.Nome == "Stefano").FirstOrDefault();
            }
        }

        private void LeggeLocalita()
        {
            using (MyDbContext ctx = new MyDbContext(connectionString))
            {
                //Localita localita = ctx.Localita.Where(q => q.Nome == "Roma").FirstOrDefault();
            }
        }

        private void ModificaUnElemento()
        {
            using (MyDbContext ctx = new MyDbContext(connectionString))
            {
                //var item = ctx.Prodotto.Where(q => q.Descrizione.Substring(0, 1) == "r").FirstOrDefault();
                //item.Descrizione = "elemento modificato";
                //ctx.SaveChanges();
            }
        }

        private void ModificaGlobale()
        {
            using (MyDbContext ctx = new MyDbContext(connectionString))
            {
                //ctx.Prodotto.Where(q => q.Descrizione.Substring(0, 1) == "r").ToList().ForEach(q => q.Tipo = 1);
                //ctx.SaveChanges();
            }
        }

        private void Inserimento()
        {
            using (MyDbContext ctx = new MyDbContext(connectionString))
            {
                //Prodotto p = new Prodotto();
                //p.Descrizione = "Nuovo prodotto";
                //p.Tipo = 3;
                //ctx.Prodotto.Add(p);
                //ctx.SaveChanges();
            }
        }

        private void Cancellazione()
        {
            using (MyDbContext ctx = new MyDbContext(connectionString))
            {
                //var item = ctx.Prodotto.Where(q => q.Descrizione == "Nuovo prodotto").FirstOrDefault();
                //if (item != null)
                //{
                //    ctx.Prodotto.Remove(item);
                //    ctx.SaveChanges();
                //}
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MyDbContext ctx = new MyDbContext(connectionString))
            {
                Persona persona = ctx.Persone.Where(q => q.Nome == tx_Nome.Text && q.Cognome == tx_Cognome.Text).FirstOrDefault();
                if (persona == null)
                {
                    persona = new Persona();
                    ctx.Persone.Add(persona);
                    persona.Nome = tx_Nome.Text;
                    persona.Cognome = tx_Cognome.Text;
                }

                persona.DataNascita = tx_DataNascita.Value;
                persona.Email = tx_Email.Text;
                ctx.SaveChanges();

            }
        }

        private void btn_Elimina_Click(object sender, EventArgs e)
        {
            using (MyDbContext ctx = new MyDbContext(connectionString))
            {
                Persona persona = ctx.Persone.Where(q => q.Nome == tx_Nome.Text && q.Cognome == tx_Cognome.Text).FirstOrDefault();
                if (persona != null)
                {
                    ctx.Persone.Remove(persona);
                    ctx.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Persona non trovata!");
                }
            }
        }

        private void btn_Visualizza_Click(object sender, EventArgs e)
        {
            using (MyDbContext ctx = new MyDbContext(connectionString))
            {
                Giocatore giocatore = ctx.Giocatori.FirstOrDefault();
                Persona persona = ctx.Persone.FirstOrDefault();
                string nome = giocatore?.Persona.Nome;




                IQueryable<Persona> query = ctx.Persone;

                if (!String.IsNullOrEmpty(tx_Cognome.Text))
                    query = query.Where(q => q.Cognome.Contains(tx_Cognome.Text));
                if (!String.IsNullOrEmpty(tx_Nome.Text))
                    query = query.Where(q => q.Nome.Contains(tx_Nome.Text));
                var lista = query.ToList();
                dg_Persone.DataSource = lista;
                //dg_Persone.DataSource = lista.Select(q => new { q.Nome, q.Cognome, q.Email, Data = q.DataNascita}).ToList();

            }
         }

        private void dg_Persone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (MyDbContext ctx = new MyDbContext(connectionString))
            {
                if (dg_Persone.Columns[e.ColumnIndex].Name == "Delete")
                {
                    var result = MessageBox.Show("Confermi la cancellazione?", "Chess", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        int id = (int)dg_Persone.Rows[e.RowIndex].Cells["IdPersona"].Value;

                        Persona persona = ctx.Persone.Find(id);

                        if (persona != null)
                        {
                            ctx.Persone.Remove(persona);
                            ctx.SaveChanges();
                            btn_Visualizza_Click(null, null);
                        }
    
                    }
                }
            }

        }
    }
}
