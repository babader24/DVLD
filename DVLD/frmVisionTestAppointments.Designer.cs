namespace DVLD
{
    partial class frmVisionTestAppointments
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lRecordCount = new System.Windows.Forms.Label();
            this.dgvApplication = new System.Windows.Forms.DataGridView();
            this.btnAddApplication = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ucApplicationBasicInfo1 = new DVLD.ucApplicationBasicInfo();
            this.ucDrivinglicenseApplicationInfo1 = new DVLD.ucDrivinglicenseApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.eye_480px;
            this.pictureBox1.Location = new System.Drawing.Point(361, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(315, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vision Test Appointment";
            // 
            // lRecordCount
            // 
            this.lRecordCount.AutoSize = true;
            this.lRecordCount.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecordCount.Location = new System.Drawing.Point(16, 793);
            this.lRecordCount.Name = "lRecordCount";
            this.lRecordCount.Size = new System.Drawing.Size(117, 27);
            this.lRecordCount.TabIndex = 17;
            this.lRecordCount.Text = "#Record : ";
            // 
            // dgvApplication
            // 
            this.dgvApplication.AllowUserToAddRows = false;
            this.dgvApplication.AllowUserToDeleteRows = false;
            this.dgvApplication.BackgroundColor = System.Drawing.Color.White;
            this.dgvApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplication.GridColor = System.Drawing.Color.White;
            this.dgvApplication.Location = new System.Drawing.Point(21, 618);
            this.dgvApplication.Name = "dgvApplication";
            this.dgvApplication.ReadOnly = true;
            this.dgvApplication.RowHeadersWidth = 51;
            this.dgvApplication.RowTemplate.Height = 26;
            this.dgvApplication.Size = new System.Drawing.Size(978, 148);
            this.dgvApplication.TabIndex = 18;
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.BackColor = System.Drawing.Color.White;
            this.btnAddApplication.BackgroundImage = global::DVLD.Properties.Resources.add_user_480px;
            this.btnAddApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddApplication.Location = new System.Drawing.Point(941, 570);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(58, 42);
            this.btnAddApplication.TabIndex = 19;
            this.btnAddApplication.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "Appoinments";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = global::DVLD.Properties.Resources.close_pane_320px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Location = new System.Drawing.Point(894, 781);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 56);
            this.btnClose.TabIndex = 21;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucApplicationBasicInfo1
            // 
            this.ucApplicationBasicInfo1.Location = new System.Drawing.Point(21, 298);
            this.ucApplicationBasicInfo1.Name = "ucApplicationBasicInfo1";
            this.ucApplicationBasicInfo1.Size = new System.Drawing.Size(978, 277);
            this.ucApplicationBasicInfo1.TabIndex = 4;
            // 
            // ucDrivinglicenseApplicationInfo1
            // 
            this.ucDrivinglicenseApplicationInfo1.Location = new System.Drawing.Point(21, 167);
            this.ucDrivinglicenseApplicationInfo1.Name = "ucDrivinglicenseApplicationInfo1";
            this.ucDrivinglicenseApplicationInfo1.Size = new System.Drawing.Size(985, 145);
            this.ucDrivinglicenseApplicationInfo1.TabIndex = 3;
            // 
            // frmVisionTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 945);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddApplication);
            this.Controls.Add(this.dgvApplication);
            this.Controls.Add(this.lRecordCount);
            this.Controls.Add(this.ucApplicationBasicInfo1);
            this.Controls.Add(this.ucDrivinglicenseApplicationInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(1036, 992);
            this.Name = "frmVisionTestAppointments";
            this.Text = "frmVisionTestAppointments";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ucDrivinglicenseApplicationInfo ucDrivinglicenseApplicationInfo1;
        private ucApplicationBasicInfo ucApplicationBasicInfo1;
        private System.Windows.Forms.Label lRecordCount;
        private System.Windows.Forms.DataGridView dgvApplication;
        private System.Windows.Forms.Button btnAddApplication;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
    }
}