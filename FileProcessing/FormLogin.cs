using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FileProcessing
{
    public partial class FormLogin : Form
    {

        public string Username { get { return txtUsername.Text; } }
        public string Password { get { return txtPassword.Text; } }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
