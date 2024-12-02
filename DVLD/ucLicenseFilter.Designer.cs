namespace DVLD
{
    partial class ucLicenseFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picFindLicense = new System.Windows.Forms.PictureBox();
            this.tbFindLicense = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFindLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picFindLicense);
            this.groupBox1.Controls.Add(this.tbFindLicense);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // picFindLicense
            // 
            this.picFindLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFindLicense.Image = global::DVLD.Properties.Resources.taxi_license_512px;
            this.picFindLicense.Location = new System.Drawing.Point(475, 14);
            this.picFindLicense.Name = "picFindLicense";
            this.picFindLicense.Size = new System.Drawing.Size(63, 46);
            this.picFindLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFindLicense.TabIndex = 3;
            this.picFindLicense.TabStop = false;
            this.picFindLicense.Click += new System.EventHandler(this.picFindLicense_Click);
            // 
            // tbFindLicense
            // 
            this.tbFindLicense.Location = new System.Drawing.Point(169, 23);
            this.tbFindLicense.Name = "tbFindLicense";
            this.tbFindLicense.Size = new System.Drawing.Size(290, 24);
            this.tbFindLicense.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "License ID :  ";
            // 
            // ucLicenseFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucLicenseFilter";
            this.Size = new System.Drawing.Size(628, 87);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFindLicense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picFindLicense;
        public System.Windows.Forms.TextBox tbFindLicense;
        private System.Windows.Forms.Label label1;
    }
}
