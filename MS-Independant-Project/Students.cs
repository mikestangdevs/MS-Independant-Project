using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_Independant_Project
{
    public partial class Students : Form
    {
        DataTable dtStudent = new DataTable();
        public Students()
        {
            InitializeComponent();
            FillStudentDGV();
        }

        private void FillStudentDGV()
        {
            string sqlStudent = "SELECT * FROM STUDENT";

            if (Walton_DB.FillDataTable_ViaSql(ref dtStudent, sqlStudent) == true)
            {
                dgvStudent.DataSource = dtStudent;
                dgvStudent.Refresh();
            }

            else
            {
                MessageBox.Show("An error occured while populating the Student data grid view");
                return;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void instructorsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void Students_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool QuerySuccessful = false;
            SqlCommand cmd = new SqlCommand("INSERT INTO STUDENT (SID, NAME, MAJOR, GRADELVL, AGE) VALUES (" + txtSID.Text + ", '" + txtName.Text + "', '" + txtMajor.Text + "', '" + txtGradelvl.Text + "', " + txtAge.Text + ")");
            QuerySuccessful = Walton_DB.ExecSqlCommand(ref cmd);

            if (QuerySuccessful)
            {
                // Name successfully entered, notify user and clear textbox
                MessageBox.Show("Student '" + txtSID.Text + "' has been succesfully added");
                txtName.Text = "";
            }
            else
            {
                // Error occurred, notify user, do not clear textbox
                MessageBox.Show("An error occurred while entering student " + txtSID.Text + " into the database.");

            }
            FillStudentDGV();
            }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool QuerySuccessful = false;
            SqlCommand cmd = new SqlCommand("UPDATE STUDENT SET SID = '" + txtSID.Text + "' , NAME = '" + txtName.Text + "' , MAJOR = '" + txtMajor.Text + "' , GRADELVL = '" + txtGradelvl.Text + "' , AGE = '" + txtAge.Text + "' WHERE SID = '" + txtSID.Text + "'");
            QuerySuccessful = Walton_DB.ExecSqlCommand(ref cmd);

            if (QuerySuccessful)
            {
                // Name successfully entered, notify user and clear textbox
                MessageBox.Show("Student '" + txtSID.Text + "' has been succesfully updated");
                txtSID.Text = "";
            }
            else
            {
                // Error occurred, notify user, do not clear textbox
                MessageBox.Show("An error occurred while updating student " + txtSID.Text);
            }

            FillStudentDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool QuerySuccessful = false;
            SqlCommand cmd = new SqlCommand("DELETE FROM STUDENT WHERE SID = " + txtSID.Text);
            QuerySuccessful = Walton_DB.ExecSqlCommand(ref cmd);
            if (QuerySuccessful)
            {
                // Name successfully entered, notify user and clear textbox
                MessageBox.Show("Student '" + txtSID.Text + "' has been succesfully deleted");
                txtSID.Text = "";
            }
            else
            {
                // Error occurred, notify user, do not clear textbox
                MessageBox.Show("An error occurred while deleting student " + txtSID.Text);
            }

            FillStudentDGV();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new HomePage();
            newForm.Show();
        }
    }
}
