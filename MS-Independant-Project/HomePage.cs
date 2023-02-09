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
    public partial class HomePage : Form
    {

        public HomePage()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Students();
            newForm.Show();
        }

        private void btnInstructor_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Instructors();
            newForm.Show();
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Classes();
            newForm.Show();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new MultiView();
            newForm.Show();
        }
    }
}
