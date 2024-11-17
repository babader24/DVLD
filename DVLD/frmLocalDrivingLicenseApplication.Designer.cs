namespace DVLD
{
    partial class frmLocalDrivingLicenseApplication
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
            this.components = new System.ComponentModel.Container();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvApplication = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lRecordCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddApplication = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.showApplicationDeatailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleVisonTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleVisonTestToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleVisonTestToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicensesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicensesHistoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplication)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(395, 274);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(153, 24);
            this.tbFilter.TabIndex = 17;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // cbFilters
            // 
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Location = new System.Drawing.Point(199, 274);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(190, 24);
            this.cbFilters.TabIndex = 13;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.8F);
            this.label1.Location = new System.Drawing.Point(487, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Local Driving Licenses Applications";
            // 
            // dgvApplication
            // 
            this.dgvApplication.AllowUserToAddRows = false;
            this.dgvApplication.AllowUserToDeleteRows = false;
            this.dgvApplication.BackgroundColor = System.Drawing.Color.White;
            this.dgvApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplication.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvApplication.GridColor = System.Drawing.Color.White;
            this.dgvApplication.Location = new System.Drawing.Point(18, 20);
            this.dgvApplication.Name = "dgvApplication";
            this.dgvApplication.ReadOnly = true;
            this.dgvApplication.RowHeadersWidth = 51;
            this.dgvApplication.RowTemplate.Height = 26;
            this.dgvApplication.Size = new System.Drawing.Size(1380, 297);
            this.dgvApplication.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDeatailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.cancelApplicationToolStripMenuItem,
            this.sechduleIssueToolStripMenuItem,
            this.toolStripSeparator3,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicensesHistoryToolStripMenuItem,
            this.toolStripSeparator2,
            this.showPersonLicensesHistoryToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(297, 230);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(293, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(293, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(293, 6);
            // 
            // lRecordCount
            // 
            this.lRecordCount.AutoSize = true;
            this.lRecordCount.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecordCount.Location = new System.Drawing.Point(57, 665);
            this.lRecordCount.Name = "lRecordCount";
            this.lRecordCount.Size = new System.Drawing.Size(117, 27);
            this.lRecordCount.TabIndex = 16;
            this.lRecordCount.Text = "#Record : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvApplication);
            this.groupBox1.Location = new System.Drawing.Point(25, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1415, 336);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.BackColor = System.Drawing.Color.White;
            this.btnAddApplication.BackgroundImage = global::DVLD.Properties.Resources.add_user_480px;
            this.btnAddApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddApplication.Location = new System.Drawing.Point(1367, 245);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(73, 53);
            this.btnAddApplication.TabIndex = 14;
            this.btnAddApplication.UseVisualStyleBackColor = false;
            this.btnAddApplication.Click += new System.EventHandler(this.btnAddApplication_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.database_administrator_480px;
            this.pictureBox1.Location = new System.Drawing.Point(555, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = global::DVLD.Properties.Resources.close_pane_320px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Location = new System.Drawing.Point(1367, 653);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 43);
            this.btnClose.TabIndex = 15;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // showApplicationDeatailsToolStripMenuItem
            // 
            this.showApplicationDeatailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.show_property_480px;
            this.showApplicationDeatailsToolStripMenuItem.Name = "showApplicationDeatailsToolStripMenuItem";
            this.showApplicationDeatailsToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.showApplicationDeatailsToolStripMenuItem.Text = "Show Application Deatails";
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.renew_480px;
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.delete_document_480px;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.cancel_480px;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // sechduleIssueToolStripMenuItem
            // 
            this.sechduleIssueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sechduleVisonTestToolStripMenuItem,
            this.sechduleVisonTestToolStripMenuItem1,
            this.sechduleVisonTestToolStripMenuItem2});
            this.sechduleIssueToolStripMenuItem.Image = global::DVLD.Properties.Resources.calendar_30_480px;
            this.sechduleIssueToolStripMenuItem.Name = "sechduleIssueToolStripMenuItem";
            this.sechduleIssueToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.sechduleIssueToolStripMenuItem.Text = "Sechdule Issue";
            // 
            // sechduleVisonTestToolStripMenuItem
            // 
            this.sechduleVisonTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.eye_480px;
            this.sechduleVisonTestToolStripMenuItem.Name = "sechduleVisonTestToolStripMenuItem";
            this.sechduleVisonTestToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.sechduleVisonTestToolStripMenuItem.Text = "Sechdule Vison Test";
            // 
            // sechduleVisonTestToolStripMenuItem1
            // 
            this.sechduleVisonTestToolStripMenuItem1.Image = global::DVLD.Properties.Resources.edit_property_480px;
            this.sechduleVisonTestToolStripMenuItem1.Name = "sechduleVisonTestToolStripMenuItem1";
            this.sechduleVisonTestToolStripMenuItem1.Size = new System.Drawing.Size(235, 26);
            this.sechduleVisonTestToolStripMenuItem1.Text = "Sechdule Written Test";
            // 
            // sechduleVisonTestToolStripMenuItem2
            // 
            this.sechduleVisonTestToolStripMenuItem2.Image = global::DVLD.Properties.Resources.car_400px;
            this.sechduleVisonTestToolStripMenuItem2.Name = "sechduleVisonTestToolStripMenuItem2";
            this.sechduleVisonTestToolStripMenuItem2.Size = new System.Drawing.Size(235, 26);
            this.sechduleVisonTestToolStripMenuItem2.Text = "Sechdule Street Test";
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Enabled = false;
            this.showLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.taxi_license_512px;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.showLicenseToolStripMenuItem.Text = "Issue Driving License (First Time)";
            // 
            // showPersonLicensesHistoryToolStripMenuItem
            // 
            this.showPersonLicensesHistoryToolStripMenuItem.Enabled = false;
            this.showPersonLicensesHistoryToolStripMenuItem.Image = global::DVLD.Properties.Resources.taxi_license_512px;
            this.showPersonLicensesHistoryToolStripMenuItem.Name = "showPersonLicensesHistoryToolStripMenuItem";
            this.showPersonLicensesHistoryToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.showPersonLicensesHistoryToolStripMenuItem.Text = "show License";
            // 
            // showPersonLicensesHistoryToolStripMenuItem1
            // 
            this.showPersonLicensesHistoryToolStripMenuItem1.Image = global::DVLD.Properties.Resources.driver_400px;
            this.showPersonLicensesHistoryToolStripMenuItem1.Name = "showPersonLicensesHistoryToolStripMenuItem1";
            this.showPersonLicensesHistoryToolStripMenuItem1.Size = new System.Drawing.Size(296, 26);
            this.showPersonLicensesHistoryToolStripMenuItem1.Text = "Show Person Licenses History";
            // 
            // frmLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 709);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.btnAddApplication);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lRecordCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLocalDrivingLicenseApplication";
            this.Text = "frmLocalDrivingLicenseApplication";
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplication)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Button btnAddApplication;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvApplication;
        private System.Windows.Forms.Label lRecordCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDeatailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicensesHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicensesHistoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sechduleVisonTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleVisonTestToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sechduleVisonTestToolStripMenuItem2;
    }
}