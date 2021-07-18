using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FileProcessing
{
    public partial class FormAddStudent : Form
    {
        //public string Username { get { return txtUsername.Text; } }
        //public string Password { get { return txtPassword.Text; } }

        public int ID { get { return int.Parse(txtID.Text); } }
        public string FirstName { get { return txtFirstName.Text; } }
        public string LastName { get { return txtLastName.Text; } }
        public int Test1 { get { return int.Parse(txtTest1.Text); } }
        public int Test2 { get { return int.Parse(txtTest2.Text); } }
        public string Major { get { return cbMajor.Text; } }
        public string Degree { get { if (radUg.Checked) return radUg.Text; else return radGrad.Text; } }
        public FormAddStudent()
        {
            InitializeComponent();
        }

        
    }
}
