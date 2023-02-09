using MS_Independant_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_Independant_Project
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void instructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new HomePage();
            newForm.Show();
        }

        private void instructorsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Instructors();
            newForm.Show();
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Classes();
            newForm.Show();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new MultiView();
            newForm.Show();
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            bool QuerySuccessful = false;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Username WHERE UserName = '" + txtUsername.Text + "', Password = '" + txtPassword.Text + "' ");
            QuerySuccessful = Walton_DB.ExecSqlCommand(ref cmd);
            if (QuerySuccessful)
            {
                MessageBox.Show("Succesful Login");
                this.Hide();
                var newForm = new HomePage();
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Adding User");
                bool LoginSuccessful = false;
                SqlCommand uncmd = new SqlCommand("INSERT INTO UserName (UserName, Password) VALUES ('" + txtUsername.Text + "', PW = '" + txtPassword.Text + "')");
                LoginSuccessful = Walton_DB.ExecSqlCommand(ref uncmd);
                this.Hide();
                var newForm = new HomePage();
                newForm.Show();
            }
        }
    }
}

//bool QuerySuccessful = false;
//SqlCommand cmd = new SqlCommand("SELECT * FROM USERNAME WHERE USERNAME = '" + txtUsername.Text + "', Password = '" + txtPassword.Text + "' ");
//QuerySuccessful = Walton_DB.ExecSqlCommand(ref cmd);
//if (QuerySuccessful)
//{
//    MessageBox.Show("Succesful Login");
//    this.Hide();
//    var newForm = new HomePage();
//    newForm.Show();
//}
//else
//{
//    MessageBox.Show("Adding User");
//    bool LoginSuccessful = false;
//     SqlCommand uncmd = new SqlCommand("INSERT INTO USERS (UN, PW) VALUES ('" + txtUN.Text + "', PW = '" + txtPW.Text + "')");
// LoginSuccessful = Walton_DB.ExecSqlCommand(ref uncmd);
// this.Hide();
// var newForm = new HomePage();
// newForm.Show();
//}
