namespace DVLD
{
    partial class frmManageDetainedLicenses
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
            this.dgvDetained = new System.Windows.Forms.DataGridView();
            this.lRecordCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRelese = new System.Windows.Forms.Button();
            this.btnDetain = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDeatailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicensesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicensesHistoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reaseDeitanedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetained)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(339, 242);
            this.tbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(132, 20);
            this.tbFilter.TabIndex = 26;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // cbFilters
            // 
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Location = new System.Drawing.Point(171, 242);
            this.cbFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(163, 21);
            this.cbFilters.TabIndex = 22;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Search Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.8F);
            this.label1.Location = new System.Drawing.Point(474, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mamange Detained Licenses";
            // 
            // dgvDetained
            // 
            this.dgvDetained.AllowUserToAddRows = false;
            this.dgvDetained.AllowUserToDeleteRows = false;
            this.dgvDetained.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetained.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetained.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDetained.GridColor = System.Drawing.Color.White;
            this.dgvDetained.Location = new System.Drawing.Point(40, 275);
            this.dgvDetained.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDetained.Name = "dgvDetained";
            this.dgvDetained.ReadOnly = true;
            this.dgvDetained.RowHeadersWidth = 51;
            this.dgvDetained.RowTemplate.Height = 26;
            this.dgvDetained.Size = new System.Drawing.Size(1183, 241);
            this.dgvDetained.TabIndex = 18;
            // 
            // lRecordCount
            // 
            this.lRecordCount.AutoSize = true;
            this.lRecordCount.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecordCount.Location = new System.Drawing.Point(52, 540);
            this.lRecordCount.Name = "lRecordCount";
            this.lRecordCount.Size = new System.Drawing.Size(98, 23);
            this.lRecordCount.TabIndex = 25;
            this.lRecordCount.Text = "#Record : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.no_access_480px;
            this.pictureBox1.Location = new System.Drawing.Point(479, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnRelese
            // 
            this.btnRelese.BackColor = System.Drawing.Color.White;
            this.btnRelese.BackgroundImage = global::DVLD.Properties.Resources.edit_property_480px;
            this.btnRelese.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRelese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelese.Location = new System.Drawing.Point(1081, 205);
            this.btnRelese.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRelese.Name = "btnRelese";
            this.btnRelese.Size = new System.Drawing.Size(73, 58);
            this.btnRelese.TabIndex = 23;
            this.btnRelese.UseVisualStyleBackColor = false;
            this.btnRelese.Click += new System.EventHandler(this.btnRelese_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.BackColor = System.Drawing.Color.IndianRed;
            this.btnDetain.BackgroundImage = global::DVLD.Properties.Resources.srop;
            this.btnDetain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetain.Location = new System.Drawing.Point(1160, 205);
            this.btnDetain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(63, 58);
            this.btnDetain.TabIndex = 23;
            this.btnDetain.UseVisualStyleBackColor = false;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = global::DVLD.Properties.Resources.close_pane_320px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Location = new System.Drawing.Point(1175, 531);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 35);
            this.btnClose.TabIndex = 24;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDeatailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.showPersonLicensesHistoryToolStripMenuItem,
            this.showPersonLicensesHistoryToolStripMenuItem1,
            this.reaseDeitanedLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(235, 136);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showApplicationDeatailsToolStripMenuItem
            // 
            this.showApplicationDeatailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.show_property_480px;
            this.showApplicationDeatailsToolStripMenuItem.Name = "showApplicationDeatailsToolStripMenuItem";
            this.showApplicationDeatailsToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.showApplicationDeatailsToolStripMenuItem.Text = "Show Application Deatails";
            this.showApplicationDeatailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDeatailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // showPersonLicensesHistoryToolStripMenuItem
            // 
            this.showPersonLicensesHistoryToolStripMenuItem.Image = global::DVLD.Properties.Resources.taxi_license_512px;
            this.showPersonLicensesHistoryToolStripMenuItem.Name = "showPersonLicensesHistoryToolStripMenuItem";
            this.showPersonLicensesHistoryToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.showPersonLicensesHistoryToolStripMenuItem.Text = "show License Info";
            this.showPersonLicensesHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicensesHistoryToolStripMenuItem_Click);
            // 
            // showPersonLicensesHistoryToolStripMenuItem1
            // 
            this.showPersonLicensesHistoryToolStripMenuItem1.Image = global::DVLD.Properties.Resources.driver_400px;
            this.showPersonLicensesHistoryToolStripMenuItem1.Name = "showPersonLicensesHistoryToolStripMenuItem1";
            this.showPersonLicensesHistoryToolStripMenuItem1.Size = new System.Drawing.Size(234, 26);
            this.showPersonLicensesHistoryToolStripMenuItem1.Text = "Show Person Licenses History";
            this.showPersonLicensesHistoryToolStripMenuItem1.Click += new System.EventHandler(this.showPersonLicensesHistoryToolStripMenuItem1_Click);
            // 
            // reaseDeitanedLicenseToolStripMenuItem
            // 
            this.reaseDeitanedLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_property_480px;
            this.reaseDeitanedLicenseToolStripMenuItem.Name = "reaseDeitanedLicenseToolStripMenuItem";
            this.reaseDeitanedLicenseToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.reaseDeitanedLicenseToolStripMenuItem.Text = "Rease Deitaned License";
            this.reaseDeitanedLicenseToolStripMenuItem.Click += new System.EventHandler(this.reaseDeitanedLicenseToolStripMenuItem_Click);
            // 
            // frmManageDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 576);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvDetained);
            this.Controls.Add(this.btnRelese);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.lRecordCount);
            this.Controls.Add(this.btnClose);
            this.Name = "frmManageDetainedLicenses";
            this.Text = "frmManageDetainedLicenses";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetained)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvDetained;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.Label lRecordCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRelese;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDeatailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicensesHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicensesHistoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reaseDeitanedLicenseToolStripMenuItem;
    }
}