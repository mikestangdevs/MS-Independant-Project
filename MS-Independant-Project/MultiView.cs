using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_Independant_Project
{
    public partial class MultiView : Form
    {
        DataTable dtClasses = new DataTable();
        DataTable dtStudent = new DataTable();
        DataTable dtInstructor = new DataTable();
        DataTable dtEnroll = new DataTable();
        public MultiView()
        {
            InitializeComponent();
            FillClassesDGV();
            FillStudentDGV();
            FillInstructorDGV();
            FillEnrollDGV();
        }

        private void FillClassesDGV()
        {
            string sqlClasses = "SELECT * FROM ClASS";

            if (Walton_DB.FillDataTable_ViaSql(ref dtClasses, sqlClasses) == true)
            {
                dgvClasses.DataSource = dtClasses;
                dgvClasses.Refresh();
            }

            else
            {
                MessageBox.Show("An error occured while populating the Classes data grid view");
                return;
            }
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

        private void FillEnrollDGV()
        {
            string sqlEnroll = "SELECT * FROM Enroll";

            if (Walton_DB.FillDataTable_ViaSql(ref dtInstructor, sqlEnroll) == true)
            {
                dgvEnroll.DataSource = dtEnroll;
                dgvEnroll.Refresh();
            }

            else
            {
                MessageBox.Show("An error occured while populating the Enroll data grid view");
                return;
            }
        }





        private void picHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new HomePage();
            newForm.Show();
        }

        private void MultiView_Load(object sender, EventArgs e)
        {

        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
