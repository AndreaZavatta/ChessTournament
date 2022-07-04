using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public abstract class FormMaster:Form
    {
        private static string connectionString;
        protected FormMaster()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            InitializeComponent();
        }

        public abstract void InitializeComponent();


    }
}
