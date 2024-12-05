namespace DVLD
{
    partial class frmIssueDrivingLicenseFirstTime
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
            this.lMainTitle = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pbMainPhoto = new System.Windows.Forms.PictureBox();
            this.ucApplicationBasicInfo1 = new DVLD.ucApplicationBasicInfo();
            this.ucDrivinglicenseApplicationInfo1 = new DVLD.ucDrivinglicenseApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lMainTitle
            // 
            this.lMainTitle.AutoSize = true;
            this.lMainTitle.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.lMainTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lMainTitle.Location = new System.Drawing.Point(351, 144);
            this.lMainTitle.Name = "lMainTitle";
            this.lMainTitle.Size = new System.Drawing.Size(331, 35);
            this.lMainTitle.TabIndex = 6;
            this.lMainTitle.Text = "IssueDrivingLicense";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(166, 596);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(811, 142);
            this.tbNotes.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 601);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Notes";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = global::DVLD.Properties.Resources.close_pane_320px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Location = new System.Drawing.Point(731, 744);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 43);
            this.btnClose.TabIndex = 43;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.White;
            this.Savebtn.BackgroundImage = global::DVLD.Properties.Resources.save_480px;
            this.Savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Savebtn.Location = new System.Drawing.Point(873, 744);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(104, 43);
            this.Savebtn.TabIndex = 42;
            this.Savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVLD.Properties.Resources.edit_property_480px;
            this.pictureBox8.Location = new System.Drawing.Point(109, 601);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(36, 28);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 40;
            this.pictureBox8.TabStop = false;
            // 
            // pbMainPhoto
            // 
            this.pbMainPhoto.Image = global::DVLD.Properties.Resources.taxi_license_512px;
            this.pbMainPhoto.Location = new System.Drawing.Point(368, 14);
            this.pbMainPhoto.Name = "pbMainPhoto";
            this.pbMainPhoto.Size = new System.Drawing.Size(295, 127);
            this.pbMainPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainPhoto.TabIndex = 5;
            this.pbMainPhoto.TabStop = false;
            // 
            // ucApplicationBasicInfo1
            // 
            this.ucApplicationBasicInfo1.Location = new System.Drawing.Point(9, 313);
            this.ucApplicationBasicInfo1.Name = "ucApplicationBasicInfo1";
            this.ucApplicationBasicInfo1.Size = new System.Drawing.Size(978, 277);
            this.ucApplicationBasicInfo1.TabIndex = 8;
            // 
            // ucDrivinglicenseApplicationInfo1
            // 
            this.ucDrivinglicenseApplicationInfo1.Location = new System.Drawing.Point(9, 182);
            this.ucDrivinglicenseApplicationInfo1.Name = "ucDrivinglicenseApplicationInfo1";
            this.ucDrivinglicenseApplicationInfo1.Size = new System.Drawing.Size(985, 145);
            this.ucDrivinglicenseApplicationInfo1.TabIndex = 7;
            // 
            // frmIssueDrivingLicenseFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 802);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ucApplicationBasicInfo1);
            this.Controls.Add(this.ucDrivinglicenseApplicationInfo1);
            this.Controls.Add(this.lMainTitle);
            this.Controls.Add(this.pbMainPhoto);
            this.Name = "frmIssueDrivingLicenseFirstTime";
            this.Text = "frmIssueDrivingLicenseFirstTime";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucApplicationBasicInfo ucApplicationBasicInfo1;
        private ucDrivinglicenseApplicationInfo ucDrivinglicenseApplicationInfo1;
        private System.Windows.Forms.Label lMainTitle;
        private System.Windows.Forms.PictureBox pbMainPhoto;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button Savebtn;
    }
}