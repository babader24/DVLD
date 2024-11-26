namespace DVLD
{
    partial class frmTestAppointment
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
            this.pbMainPhoto = new System.Windows.Forms.PictureBox();
            this.lMainTitle = new System.Windows.Forms.Label();
            this.lRecordCount = new System.Windows.Forms.Label();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.btnAddAppintment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ucApplicationBasicInfo1 = new DVLD.ucApplicationBasicInfo();
            this.ucDrivinglicenseApplicationInfo1 = new DVLD.ucDrivinglicenseApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMainPhoto
            // 
            this.pbMainPhoto.Image = global::DVLD.Properties.Resources.eye_480px;
            this.pbMainPhoto.Location = new System.Drawing.Point(361, -3);
            this.pbMainPhoto.Name = "pbMainPhoto";
            this.pbMainPhoto.Size = new System.Drawing.Size(317, 156);
            this.pbMainPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainPhoto.TabIndex = 0;
            this.pbMainPhoto.TabStop = false;
            // 
            // lMainTitle
            // 
            this.lMainTitle.AutoSize = true;
            this.lMainTitle.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.lMainTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lMainTitle.Location = new System.Drawing.Point(315, 129);
            this.lMainTitle.Name = "lMainTitle";
            this.lMainTitle.Size = new System.Drawing.Size(402, 35);
            this.lMainTitle.TabIndex = 2;
            this.lMainTitle.Text = "Vision Test Appointment";
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
            // dgvAppointment
            // 
            this.dgvAppointment.AllowUserToAddRows = false;
            this.dgvAppointment.AllowUserToDeleteRows = false;
            this.dgvAppointment.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.GridColor = System.Drawing.Color.White;
            this.dgvAppointment.Location = new System.Drawing.Point(21, 618);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.ReadOnly = true;
            this.dgvAppointment.RowHeadersWidth = 51;
            this.dgvAppointment.RowTemplate.Height = 26;
            this.dgvAppointment.Size = new System.Drawing.Size(978, 148);
            this.dgvAppointment.TabIndex = 18;
            // 
            // btnAddAppintment
            // 
            this.btnAddAppintment.BackColor = System.Drawing.Color.White;
            this.btnAddAppintment.BackgroundImage = global::DVLD.Properties.Resources.add_user_480px;
            this.btnAddAppintment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAppintment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAppintment.Location = new System.Drawing.Point(941, 570);
            this.btnAddAppintment.Name = "btnAddAppintment";
            this.btnAddAppintment.Size = new System.Drawing.Size(58, 42);
            this.btnAddAppintment.TabIndex = 19;
            this.btnAddAppintment.UseVisualStyleBackColor = false;
            this.btnAddAppintment.Click += new System.EventHandler(this.btnAddAppintment_Click);
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
            // frmTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 945);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddAppintment);
            this.Controls.Add(this.dgvAppointment);
            this.Controls.Add(this.lRecordCount);
            this.Controls.Add(this.ucApplicationBasicInfo1);
            this.Controls.Add(this.ucDrivinglicenseApplicationInfo1);
            this.Controls.Add(this.lMainTitle);
            this.Controls.Add(this.pbMainPhoto);
            this.MinimumSize = new System.Drawing.Size(1036, 992);
            this.Name = "frmTestAppointment";
            this.Text = "frmTestAppointments";
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainPhoto;
        private System.Windows.Forms.Label lMainTitle;
        private ucDrivinglicenseApplicationInfo ucDrivinglicenseApplicationInfo1;
        private ucApplicationBasicInfo ucApplicationBasicInfo1;
        private System.Windows.Forms.Label lRecordCount;
        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.Button btnAddAppintment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
    }
}