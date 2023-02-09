namespace MS_Independant_Project
{
    partial class MultiView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiView));
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.dgvEnroll = new System.Windows.Forms.DataGridView();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.dgvInstructor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClasses
            // 
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Location = new System.Drawing.Point(81, 10);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowTemplate.Height = 25;
            this.dgvClasses.Size = new System.Drawing.Size(306, 211);
            this.dgvClasses.TabIndex = 0;
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(423, 10);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowTemplate.Height = 25;
            this.dgvStudent.Size = new System.Drawing.Size(306, 211);
            this.dgvStudent.TabIndex = 1;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            // 
            // dgvEnroll
            // 
            this.dgvEnroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnroll.Location = new System.Drawing.Point(423, 227);
            this.dgvEnroll.Name = "dgvEnroll";
            this.dgvEnroll.RowTemplate.Height = 25;
            this.dgvEnroll.Size = new System.Drawing.Size(306, 211);
            this.dgvEnroll.TabIndex = 2;
            // 
            // picHome
            // 
            this.picHome.Image = ((System.Drawing.Image)(resources.GetObject("picHome.Image")));
            this.picHome.Location = new System.Drawing.Point(12, 10);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(22, 23);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHome.TabIndex = 20;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // dgvInstructor
            // 
            this.dgvInstructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstructor.Location = new System.Drawing.Point(81, 227);
            this.dgvInstructor.Name = "dgvInstructor";
            this.dgvInstructor.RowTemplate.Height = 25;
            this.dgvInstructor.Size = new System.Drawing.Size(306, 211);
            this.dgvInstructor.TabIndex = 21;
            // 
            // MultiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvInstructor);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.dgvEnroll);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.dgvClasses);
            this.Name = "MultiView";
            this.Text = "MultiView";
            this.Load += new System.EventHandler(this.MultiView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvClasses;
        private DataGridView dgvStudent;
        private DataGridView dgvEnroll;
        private PictureBox picHome;
        private DataGridView dgvInstructor;
    }
}