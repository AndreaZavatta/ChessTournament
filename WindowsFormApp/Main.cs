using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void btnRegistrazione_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistrazione form = new FormRegistrazione();
            form.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin form = new FormLogin();
            form.ShowDialog();
            this.Close();
        }
    }
}
