using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class lblName : Form
    {
        public lblName()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }


        private void lblName_Load(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbType.Text)
            {
                case "Allenatore":
                    lblRating.Visible = false;
                    txtRating.Visible = false;
                    lblFederazione.Visible=true;
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

        private void btnSalva_Click(object sender, EventArgs e)
        {
            StringBuilder err = new StringBuilder();
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                err.Append($"inserire un nome{Environment.NewLine}");
            }
        }
    }
}
