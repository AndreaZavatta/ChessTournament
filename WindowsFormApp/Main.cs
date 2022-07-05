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
            FormRegistrazione form = new FormRegistrazione();
            form.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.ShowDialog();
        }
    }
}
