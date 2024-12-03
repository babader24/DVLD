namespace DVLD
{
    partial class frmReplacmentForDamegedOrLost
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
            this.ShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.ShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReplacedLicenseID = new System.Windows.Forms.Label();
            this.lOldLicenseID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lCreatedBy = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lApplicationFees = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lIDApplicationID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lApplicationID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ucDriverlicenseInfo1 = new DVLD.ucDriverlicenseInfo();
            this.lTitle = new System.Windows.Forms.Label();
            this.ucLicenseFilter1 = new DVLD.ucLicenseFilter();
            this.btnClose = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDamagedLicense = new System.Windows.Forms.RadioButton();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowLicenseInfo
            // 
            this.ShowLicenseInfo.AutoSize = true;
            this.ShowLicenseInfo.Enabled = false;
            this.ShowLicenseInfo.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold);
            this.ShowLicenseInfo.Location = new System.Drawing.Point(244, 699);
            this.ShowLicenseInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShowLicenseInfo.Name = "ShowLicenseInfo";
            this.ShowLicenseInfo.Size = new System.Drawing.Size(148, 18);
            this.ShowLicenseInfo.TabIndex = 58;
            this.ShowLicenseInfo.TabStop = true;
            this.ShowLicenseInfo.Text = "Show License Info";
            this.ShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowLicenseInfo_LinkClicked);
            // 
            // ShowLicensesHistory
            // 
            this.ShowLicensesHistory.AutoSize = true;
            this.ShowLicensesHistory.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold);
            this.ShowLicensesHistory.Location = new System.Drawing.Point(44, 699);
            this.ShowLicensesHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShowLicensesHistory.Name = "ShowLicensesHistory";
            this.ShowLicensesHistory.Size = new System.Drawing.Size(180, 18);
            this.ShowLicensesHistory.TabIndex = 59;
            this.ShowLicensesHistory.TabStop = true;
            this.ShowLicensesHistory.Text = "Show Licenses History";
            this.ShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowLicensesHistory_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReplacedLicenseID);
            this.groupBox1.Controls.Add(this.lOldLicenseID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.lCreatedBy);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lApplicationFees);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox10);
            this.groupBox1.Controls.Add(this.lIDApplicationID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.lApplicationID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(17, 509);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(858, 165);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info";
            // 
            // ReplacedLicenseID
            // 
            this.ReplacedLicenseID.AutoSize = true;
            this.ReplacedLicenseID.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplacedLicenseID.Location = new System.Drawing.Point(655, 30);
            this.ReplacedLicenseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReplacedLicenseID.Name = "ReplacedLicenseID";
            this.ReplacedLicenseID.Size = new System.Drawing.Size(57, 18);
            this.ReplacedLicenseID.TabIndex = 18;
            this.ReplacedLicenseID.Text = "???????";
            // 
            // lOldLicenseID
            // 
            this.lOldLicenseID.AutoSize = true;
            this.lOldLicenseID.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOldLicenseID.Location = new System.Drawing.Point(655, 68);
            this.lOldLicenseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lOldLicenseID.Name = "lOldLicenseID";
            this.lOldLicenseID.Size = new System.Drawing.Size(57, 18);
            this.lOldLicenseID.TabIndex = 18;
            this.lOldLicenseID.Text = "???????";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(457, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Replaced License ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(457, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Old License ID";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Enabled = false;
            this.pictureBox5.Image = global::DVLD.Properties.Resources.taxi_license_512px;
            this.pictureBox5.Location = new System.Drawing.Point(622, 30);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 22);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Enabled = false;
            this.pictureBox8.Image = global::DVLD.Properties.Resources.taxi_license_512px;
            this.pictureBox8.Location = new System.Drawing.Point(622, 68);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(29, 22);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            // 
            // lCreatedBy
            // 
            this.lCreatedBy.AutoSize = true;
            this.lCreatedBy.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCreatedBy.ForeColor = System.Drawing.Color.Black;
            this.lCreatedBy.Location = new System.Drawing.Point(655, 116);
            this.lCreatedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCreatedBy.Name = "lCreatedBy";
            this.lCreatedBy.Size = new System.Drawing.Size(64, 18);
            this.lCreatedBy.TabIndex = 15;
            this.lCreatedBy.Text = "???????";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD.Properties.Resources.man400px;
            this.pictureBox4.Location = new System.Drawing.Point(622, 116);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(457, 118);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 18);
            this.label12.TabIndex = 13;
            this.label12.Text = "Created By";
            // 
            // lApplicationFees
            // 
            this.lApplicationFees.AutoSize = true;
            this.lApplicationFees.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lApplicationFees.ForeColor = System.Drawing.Color.Black;
            this.lApplicationFees.Location = new System.Drawing.Point(196, 117);
            this.lApplicationFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lApplicationFees.Name = "lApplicationFees";
            this.lApplicationFees.Size = new System.Drawing.Size(64, 18);
            this.lApplicationFees.TabIndex = 12;
            this.lApplicationFees.Text = "???????";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD.Properties.Resources.expensive_512px;
            this.pictureBox6.Location = new System.Drawing.Point(162, 117);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(29, 22);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Application Fees";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::DVLD.Properties.Resources.bill_480px;
            this.pictureBox10.Location = new System.Drawing.Point(162, 24);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(29, 22);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            // 
            // lIDApplicationID
            // 
            this.lIDApplicationID.AutoSize = true;
            this.lIDApplicationID.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIDApplicationID.Location = new System.Drawing.Point(196, 31);
            this.lIDApplicationID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lIDApplicationID.Name = "lIDApplicationID";
            this.lIDApplicationID.Size = new System.Drawing.Size(57, 18);
            this.lIDApplicationID.TabIndex = 7;
            this.lIDApplicationID.Text = "???????";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "R D Application ID";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD.Properties.Resources.calendar_30_480px;
            this.pictureBox7.Location = new System.Drawing.Point(162, 70);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(29, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // lApplicationID
            // 
            this.lApplicationID.AutoSize = true;
            this.lApplicationID.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lApplicationID.Location = new System.Drawing.Point(196, 70);
            this.lApplicationID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lApplicationID.Name = "lApplicationID";
            this.lApplicationID.Size = new System.Drawing.Size(78, 18);
            this.lApplicationID.TabIndex = 4;
            this.lApplicationID.Text = "Issue Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Application Date";
            // 
            // ucDriverlicenseInfo1
            // 
            this.ucDriverlicenseInfo1._ID = 0;
            this.ucDriverlicenseInfo1.Location = new System.Drawing.Point(5, 158);
            this.ucDriverlicenseInfo1.Margin = new System.Windows.Forms.Padding(2);
            this.ucDriverlicenseInfo1.Name = "ucDriverlicenseInfo1";
            this.ucDriverlicenseInfo1.Size = new System.Drawing.Size(885, 356);
            this.ucDriverlicenseInfo1.TabIndex = 56;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.Red;
            this.lTitle.Location = new System.Drawing.Point(211, 36);
            this.lTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(447, 29);
            this.lTitle.TabIndex = 55;
            this.lTitle.Text = "Replacement For Damaged License";
            // 
            // ucLicenseFilter1
            // 
            this.ucLicenseFilter1.Location = new System.Drawing.Point(17, 94);
            this.ucLicenseFilter1.Margin = new System.Windows.Forms.Padding(2);
            this.ucLicenseFilter1.Name = "ucLicenseFilter1";
            this.ucLicenseFilter1.Size = new System.Drawing.Size(586, 70);
            this.ucLicenseFilter1.TabIndex = 54;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = global::DVLD.Properties.Resources.close_pane_320px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Location = new System.Drawing.Point(632, 692);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 34);
            this.btnClose.TabIndex = 61;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.White;
            this.Savebtn.BackgroundImage = global::DVLD.Properties.Resources.save_480px;
            this.Savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Savebtn.Location = new System.Drawing.Point(746, 692);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(83, 34);
            this.Savebtn.TabIndex = 60;
            this.Savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDamagedLicense);
            this.groupBox2.Controls.Add(this.rbLostLicense);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(571, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 79);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Replacement For";
            // 
            // rbDamagedLicense
            // 
            this.rbDamagedLicense.AutoSize = true;
            this.rbDamagedLicense.Checked = true;
            this.rbDamagedLicense.Location = new System.Drawing.Point(18, 25);
            this.rbDamagedLicense.Name = "rbDamagedLicense";
            this.rbDamagedLicense.Size = new System.Drawing.Size(141, 22);
            this.rbDamagedLicense.TabIndex = 0;
            this.rbDamagedLicense.TabStop = true;
            this.rbDamagedLicense.Text = "Damaged License";
            this.rbDamagedLicense.UseVisualStyleBackColor = true;
            this.rbDamagedLicense.CheckedChanged += new System.EventHandler(this.rbLostLicense_CheckedChanged);
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Location = new System.Drawing.Point(18, 53);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(105, 22);
            this.rbLostLicense.TabIndex = 0;
            this.rbLostLicense.Text = "Lost License";
            this.rbLostLicense.UseVisualStyleBackColor = true;
            this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rbLostLicense_CheckedChanged);
            // 
            // frmReplacmentForDamegedOrLost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 738);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.ShowLicenseInfo);
            this.Controls.Add(this.ShowLicensesHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucDriverlicenseInfo1);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.ucLicenseFilter1);
            this.Name = "frmReplacmentForDamegedOrLost";
            this.Text = "frmReplacmentForDamegedOrLost";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.LinkLabel ShowLicenseInfo;
        private System.Windows.Forms.LinkLabel ShowLicensesHistory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ReplacedLicenseID;
        private System.Windows.Forms.Label lOldLicenseID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lCreatedBy;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lApplicationFees;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label lIDApplicationID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lApplicationID;
        private System.Windows.Forms.Label label2;
        private ucDriverlicenseInfo ucDriverlicenseInfo1;
        private System.Windows.Forms.Label lTitle;
        private ucLicenseFilter ucLicenseFilter1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDamagedLicense;
        private System.Windows.Forms.RadioButton rbLostLicense;
    }
}