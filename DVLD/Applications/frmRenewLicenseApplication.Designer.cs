namespace DVLD
{
    partial class frmRenewLicenseApplication
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
            this.btnClose = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.ShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.ShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lOldLicenseID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lCreatedBy = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lLicenseFees = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lIDApplicationID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lExiprationDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lIssueDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lApplicationID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ucDriverlicenseInfo1 = new DVLD.ucDriverlicenseInfo();
            this.lTitle = new System.Windows.Forms.Label();
            this.ucLicenseFilter1 = new DVLD.ucLicenseFilter();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lApplicationFees = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.lTotalFees = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lRenewLicenseID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = global::DVLD.Properties.Resources.close_pane_320px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Location = new System.Drawing.Point(616, 827);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 34);
            this.btnClose.TabIndex = 53;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.White;
            this.Savebtn.BackgroundImage = global::DVLD.Properties.Resources.save_480px;
            this.Savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Savebtn.Location = new System.Drawing.Point(730, 827);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(83, 34);
            this.Savebtn.TabIndex = 52;
            this.Savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // ShowLicenseInfo
            // 
            this.ShowLicenseInfo.AutoSize = true;
            this.ShowLicenseInfo.Enabled = false;
            this.ShowLicenseInfo.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold);
            this.ShowLicenseInfo.Location = new System.Drawing.Point(228, 834);
            this.ShowLicenseInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShowLicenseInfo.Name = "ShowLicenseInfo";
            this.ShowLicenseInfo.Size = new System.Drawing.Size(148, 18);
            this.ShowLicenseInfo.TabIndex = 50;
            this.ShowLicenseInfo.TabStop = true;
            this.ShowLicenseInfo.Text = "Show License Info";
            this.ShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowLicenseInfo_LinkClicked);
            // 
            // ShowLicensesHistory
            // 
            this.ShowLicensesHistory.AutoSize = true;
            this.ShowLicensesHistory.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold);
            this.ShowLicensesHistory.Location = new System.Drawing.Point(28, 834);
            this.ShowLicensesHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShowLicensesHistory.Name = "ShowLicensesHistory";
            this.ShowLicensesHistory.Size = new System.Drawing.Size(180, 18);
            this.ShowLicensesHistory.TabIndex = 51;
            this.ShowLicensesHistory.TabStop = true;
            this.ShowLicensesHistory.Text = "Show Licenses History";
            this.ShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowLicensesHistory_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNotes);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lRenewLicenseID);
            this.groupBox1.Controls.Add(this.lOldLicenseID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.lCreatedBy);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lApplicationFees);
            this.groupBox1.Controls.Add(this.lTotalFees);
            this.groupBox1.Controls.Add(this.lLicenseFees);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox11);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBox10);
            this.groupBox1.Controls.Add(this.lIDApplicationID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.lExiprationDate);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lIssueDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lApplicationID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(17, 506);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(858, 297);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info";
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
            this.lCreatedBy.Location = new System.Drawing.Point(655, 148);
            this.lCreatedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCreatedBy.Name = "lCreatedBy";
            this.lCreatedBy.Size = new System.Drawing.Size(64, 18);
            this.lCreatedBy.TabIndex = 15;
            this.lCreatedBy.Text = "???????";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD.Properties.Resources.man400px;
            this.pictureBox4.Location = new System.Drawing.Point(622, 148);
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
            this.label12.Location = new System.Drawing.Point(457, 150);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 18);
            this.label12.TabIndex = 13;
            this.label12.Text = "Created By";
            // 
            // lLicenseFees
            // 
            this.lLicenseFees.AutoSize = true;
            this.lLicenseFees.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLicenseFees.ForeColor = System.Drawing.Color.Black;
            this.lLicenseFees.Location = new System.Drawing.Point(196, 192);
            this.lLicenseFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLicenseFees.Name = "lLicenseFees";
            this.lLicenseFees.Size = new System.Drawing.Size(64, 18);
            this.lLicenseFees.TabIndex = 12;
            this.lLicenseFees.Text = "???????";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.expensive_512px;
            this.pictureBox2.Location = new System.Drawing.Point(162, 192);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "License Fees";
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
            this.label4.Text = "R.L Application ID";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD.Properties.Resources.calendar_30_480px;
            this.pictureBox3.Location = new System.Drawing.Point(622, 106);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // lExiprationDate
            // 
            this.lExiprationDate.AutoSize = true;
            this.lExiprationDate.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lExiprationDate.Location = new System.Drawing.Point(655, 106);
            this.lExiprationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lExiprationDate.Name = "lExiprationDate";
            this.lExiprationDate.Size = new System.Drawing.Size(78, 18);
            this.lExiprationDate.TabIndex = 4;
            this.lExiprationDate.Text = "Issue Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.calendar_30_480px;
            this.pictureBox1.Location = new System.Drawing.Point(162, 107);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lIssueDate
            // 
            this.lIssueDate.AutoSize = true;
            this.lIssueDate.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIssueDate.Location = new System.Drawing.Point(196, 107);
            this.lIssueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lIssueDate.Name = "lIssueDate";
            this.lIssueDate.Size = new System.Drawing.Size(78, 18);
            this.lIssueDate.TabIndex = 4;
            this.lIssueDate.Text = "Issue Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(457, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Expiration Date";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Issue Date";
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
            this.ucDriverlicenseInfo1.Location = new System.Drawing.Point(5, 155);
            this.ucDriverlicenseInfo1.Margin = new System.Windows.Forms.Padding(2);
            this.ucDriverlicenseInfo1.Name = "ucDriverlicenseInfo1";
            this.ucDriverlicenseInfo1.Size = new System.Drawing.Size(885, 356);
            this.ucDriverlicenseInfo1.TabIndex = 48;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.Red;
            this.lTitle.Location = new System.Drawing.Point(242, 35);
            this.lTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(347, 29);
            this.lTitle.TabIndex = 47;
            this.lTitle.Text = "Renew License Application";
            // 
            // ucLicenseFilter1
            // 
            this.ucLicenseFilter1.Location = new System.Drawing.Point(17, 91);
            this.ucLicenseFilter1.Margin = new System.Windows.Forms.Padding(2);
            this.ucLicenseFilter1.Name = "ucLicenseFilter1";
            this.ucLicenseFilter1.Size = new System.Drawing.Size(586, 70);
            this.ucLicenseFilter1.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Application Fees";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD.Properties.Resources.expensive_512px;
            this.pictureBox6.Location = new System.Drawing.Point(162, 149);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(29, 22);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // lApplicationFees
            // 
            this.lApplicationFees.AutoSize = true;
            this.lApplicationFees.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lApplicationFees.ForeColor = System.Drawing.Color.Black;
            this.lApplicationFees.Location = new System.Drawing.Point(196, 149);
            this.lApplicationFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lApplicationFees.Name = "lApplicationFees";
            this.lApplicationFees.Size = new System.Drawing.Size(64, 18);
            this.lApplicationFees.TabIndex = 12;
            this.lApplicationFees.Text = "???????";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVLD.Properties.Resources.send_480px;
            this.pictureBox9.Location = new System.Drawing.Point(160, 240);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(31, 23);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 23;
            this.pictureBox9.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Note";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(215, 227);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(520, 50);
            this.tbNotes.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(457, 193);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Total Fees";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::DVLD.Properties.Resources.expensive_512px;
            this.pictureBox11.Location = new System.Drawing.Point(622, 191);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(29, 22);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            // 
            // lTotalFees
            // 
            this.lTotalFees.AutoSize = true;
            this.lTotalFees.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalFees.ForeColor = System.Drawing.Color.Black;
            this.lTotalFees.Location = new System.Drawing.Point(656, 191);
            this.lTotalFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTotalFees.Name = "lTotalFees";
            this.lTotalFees.Size = new System.Drawing.Size(64, 18);
            this.lTotalFees.TabIndex = 12;
            this.lTotalFees.Text = "???????";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(457, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Renew License ID";
            // 
            // lRenewLicenseID
            // 
            this.lRenewLicenseID.AutoSize = true;
            this.lRenewLicenseID.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRenewLicenseID.Location = new System.Drawing.Point(655, 30);
            this.lRenewLicenseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lRenewLicenseID.Name = "lRenewLicenseID";
            this.lRenewLicenseID.Size = new System.Drawing.Size(57, 18);
            this.lRenewLicenseID.TabIndex = 18;
            this.lRenewLicenseID.Text = "???????";
            // 
            // frmRenewLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 902);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.ShowLicenseInfo);
            this.Controls.Add(this.ShowLicensesHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucDriverlicenseInfo1);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.ucLicenseFilter1);
            this.Name = "frmRenewLicenseApplication";
            this.Text = "frmRenewLicenseApplication";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.LinkLabel ShowLicenseInfo;
        private System.Windows.Forms.LinkLabel ShowLicensesHistory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lOldLicenseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lCreatedBy;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lLicenseFees;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label lIDApplicationID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lExiprationDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lIssueDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lApplicationID;
        private System.Windows.Forms.Label label2;
        private ucDriverlicenseInfo ucDriverlicenseInfo1;
        private System.Windows.Forms.Label lTitle;
        private ucLicenseFilter ucLicenseFilter1;
        private System.Windows.Forms.Label lApplicationFees;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lRenewLicenseID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lTotalFees;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label11;
    }
}