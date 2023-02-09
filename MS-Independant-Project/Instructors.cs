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
    public partial class Instructors : Form
    {
        DataTable dtInstructor = new DataTable();
        public Instructors()
        {
            InitializeComponent();
            FillInstructorDGV();
        }

        private void FillInstructorDGV()
        {
            string sqlInstructor = "SELECT * FROM INSTRUCTOR";

            if (Walton_DB.FillDataTable_ViaSql(ref dtInstructor, sqlInstructor) == true)
            {
                dgvInstructor.DataSource = dtInstructor;
                dgvInstructor.Refresh();
            }

            else
            {
                MessageBox.Show("An error occured while populating the Instructor data grid view");
                return;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Instructors_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new MultiView();
            newForm.Show();
        }

        private void classsesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Classes();
            newForm.Show();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Students();
            newForm.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool QuerySuccessful = false;
            SqlCommand cmd = new SqlCommand("INSERT INTO INSTRUCTOR (TID, NAME) VALUES (" + txtTID.Text.Trim() + ",'" + txtName.Text.Trim() + "')");
            QuerySuccessful = Walton_DB.ExecSqlCommand(ref cmd);
            if (QuerySuccessful)
            {
                // Name successfully entered, notify user and clear textbox
                MessageBox.Show("Instructor '" + txtTID.Text + "' has been succesfully added");
                txtTID.Text = "";
            }
            else
            {
                // Error occurred, notify user, do not clear textbox
                MessageBox.Show("An error occurred while adding instructor " + txtTID.Text);
            }

            FillInstructorDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool QuerySuccessful = false;
            SqlCommand cmd = new SqlCommand("DELETE FROM INSTRUCTOR WHERE TID = " + txtTID.Text);
            QuerySuccessful = Walton_DB.ExecSqlCommand(ref cmd);
            if (QuerySuccessful)
            {
                // Name successfully entered, notify user and clear textbox
                MessageBox.Show("Instructor '" + txtTID.Text + "' has been succesfully deleted");
                txtTID.Text = "";
            }

            FillInstructorDGV();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool QuerySuccessful = false;
            SqlCommand cmd = new SqlCommand("UPDATE INSTRUCTOR SET TID = '" + txtTID.Text + "', NAME = '" + txtName.Text + "' WHERE TID = " + txtTID.Text);
            QuerySuccessful = Walton_DB.ExecSqlCommand(ref cmd);
            if (QuerySuccessful)
            {
                // Name successfully entered, notify user and clear textbox
                MessageBox.Show("Instructor '" + txtTID.Text + "' has been succesfully updated");
                txtTID.Text = "";
            }
            else
            {
                // Error occurred, notify user, do not clear textbox
                MessageBox.Show("An error occurred while updating instructor" + txtTID.Text);
            }

            FillInstructorDGV();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void picHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new HomePage();
            newForm.Show();
        }
    }
}
