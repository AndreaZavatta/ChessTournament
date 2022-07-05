using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnRegistrazione_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegistrazione().ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().ShowDialog();
            this.Close();
        }
    }
}
