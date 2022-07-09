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
    public partial class FormVisualizzaTornei : Form
    {
        private string _connectionString;
        public FormVisualizzaTornei()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            InitializeComponent();
        }

        private void FormVisualizzaTornei_Load(object sender, EventArgs e)
        {
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
            using (MyDbContext ctx = new MyDbContext(_connectionString))
            {
                var list = ctx.Edizioni.Where(q => q.CodiceTorneo.Equals(cbTorneo.SelectedValue))
                    .Select(q=>new {Descrizione = q.Descrizione, DataInizio=q.DataInizio, DataFine=q.DataFine}).ToList();
                dgvTornei.DataSource = list;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SharedClass.getFormUser().ShowDialog();
            this.Close();
        }

        private void dgvTornei_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (e.ColumnIndex == dgv.Columns["Details"].Index)
            {

            }
        }
    }
}
