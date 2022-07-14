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
            if (LoggedUser.Tipo != Persona.TipoUtente.Organizzatore)
            {
                btnCreaTorneo.Visible = false;
            }

            using (MyDbContext ctx = new MyDbContext(_connectionString))
            {
                List<Torneo> listTornei = ctx.Tornei.ToList();
                listTornei.Insert(0, new Torneo { Nome = "", Codice = 0 });
                cbTorneo.ValueMember = "Codice";
                cbTorneo.DisplayMember = "Nome";
                cbTorneo.DataSource = listTornei;
            }

        }

        private void cbTorneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        public void UpdateTable()
        {
            using MyDbContext ctx = new MyDbContext(_connectionString);
            var list = ctx.Edizioni.Where(q => q.CodiceTorneo.Equals(cbTorneo.SelectedValue))
                .Select(q => new { Codice = q.Codice, Descrizione = q.Descrizione, NumEdizione = q.NumEdizione, DataInizio = q.DataInizio, DataFine = q.DataFine}).ToList();
            dgvTornei.DataSource = list;
        }


        private void dgvTornei_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (e.ColumnIndex == dgv.Columns["Details"].Index)
            {
                int codice = (int)dgv.Rows[e.RowIndex].Cells[dgv.Columns["Codice"].Index].Value;
                new FormDettaglioEdzione(codice).ShowDialog();
            }
        }

        private void btnCreaTorneo_Click(object sender, EventArgs e)
        {
            var form = new FormCreaTorneo();
            form.Tag = this;
            form.ShowDialog();
        }

    }
}
