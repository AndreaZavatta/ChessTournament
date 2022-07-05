using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class FormOrganizzatore : Form
    {
        public FormOrganizzatore()
        {
            InitializeComponent();
        }

        private void btnCreaTorneo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormCreaTorneo().ShowDialog();
            this.Close();
        }

        private void btnVisualizzaTorneo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormVisualizzaTornei().ShowDialog();
            this.Close();
        }
    }
}
