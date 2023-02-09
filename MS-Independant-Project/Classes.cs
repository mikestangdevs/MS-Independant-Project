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
    public partial class Classes : Form
    {
        DataTable dtClasses = new DataTable();
        public Classes()
        {
            InitializeComponent();
            FillClassesDGV();
        }

        private void FillClassesDGV()
        {
            string sqlClasses = "SELECT * FROM ClASS";

            if (Walton_DB.FillDataTable_ViaSql(ref dtClasses, sqlClasses) == true)
            {
                dgvClasses.DataSource= dtClasses;
                dgvClasses.Refresh();
            }

            else
            {
                MessageBox.Show("An error occured while populating the Classes data grid view");
                return;
            }
        }

        private void Classes_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void instructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Instructors();
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
            SqlCommand cmd = new SqlCommand("INSERT INTO CLASS (CID, CLSTIME, TID, ROOM) VALUES ('" + txtName.Text.Trim() + "', '" + txtClsTime.Text.Trim() + "', '" + txtTID.Text.Trim() + "', '" + txtRoom.Text.Trim() + "')");
            QuerySuccessful = Walton_DB.ExecSqlCommand(ref cmd);
            if (QuerySuccessful)
            {
                // Name successfully entered, notify user and clear textbox
                MessageBox.Show("Class '" + txtName.Text + "' has been succesfully added");
                txtName.Text = "";
            }
            else
            {
                // Error occurred, notify user, do not clear textbox
                MessageBox.Show("An error occurred while adding class " + txtName.Text);
                MessageBox.Show("INSERT INTO CLASS (CID, CLSTIME, TID, ROOM) VALUES ('" + txtName.Text.Trim() + "', '" + txtClsTime.Text.Trim() + "', '" + txtTID.Text.Trim() + "', '" + txtRoom.Text.Trim() + "')");
            }

            FillClassesDGV();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool QuerySuccessful = false;
            SqlCommand cmd = new SqlCommand("UPDATE CLASS SET CID = '" + txtName.Text + "', CLSTIME = '" + txtClsTime.Text + "', TID = '" + txtTID.Text + "', ROOM = '" + txtRoom.Text + "' WHERE CID = '" + txtName.Text + "'");
            QuerySuccessful = Walton_DB.ExecSqlCommand(ref cmd);
            if (QuerySuccessful)
            {
                // Name successfully entered, notify user and clear textbox
                MessageBox.Show("Class '" + txtName.Text + "' has been succesfully updated");
                txtName.Text = "";
            }
            else
            {
                // Error occurred, notify user, do not clear textbox
                MessageBox.Show("An error occurred while updating class " + txtName.Text);
            }

            FillClassesDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool QuerySuccessful = false;
            SqlCommand cmd = new SqlCommand("DELETE FROM CLASS WHERE CID = '" + txtName.Text + "'");
            QuerySuccessful = Walton_DB.ExecSqlCommand(ref cmd);
            if (QuerySuccessful)
            {
                // Name successfully entered, notify user and clear textbox
                MessageBox.Show("Class '" + txtName.Text + "' has been succesfully deleted");
                txtName.Text = "";
            }
            else
            {
                // Error occurred, notify user, do not clear textbox
                MessageBox.Show("An error occurred while deleting class " + txtName.Text);
            }

            FillClassesDGV();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new HomePage();
            newForm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
