namespace DVLD
{
    partial class Filter
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
            this.picAddPerson = new System.Windows.Forms.PictureBox();
            this.picFindPerson = new System.Windows.Forms.PictureBox();
            this.tbFindPerson = new System.Windows.Forms.TextBox();
            this.cbFindPerson = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFindPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picAddPerson);
            this.groupBox1.Controls.Add(this.picFindPerson);
            this.groupBox1.Controls.Add(this.tbFindPerson);
            this.groupBox1.Controls.Add(this.cbFindPerson);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // picAddPerson
            // 
            this.picAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddPerson.Image = global::DVLD.Properties.Resources.add_user_480px;
            this.picAddPerson.Location = new System.Drawing.Point(738, 24);
            this.picAddPerson.Name = "picAddPerson";
            this.picAddPerson.Size = new System.Drawing.Size(41, 25);
            this.picAddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddPerson.TabIndex = 3;
            this.picAddPerson.TabStop = false;
            this.picAddPerson.Click += new System.EventHandler(this.picAddPerson_Click);
            // 
            // picFindPerson
            // 
            this.picFindPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFindPerson.Image = global::DVLD.Properties.Resources.gendor_480px;
            this.picFindPerson.Location = new System.Drawing.Point(682, 23);
            this.picFindPerson.Name = "picFindPerson";
            this.picFindPerson.Size = new System.Drawing.Size(41, 25);
            this.picFindPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFindPerson.TabIndex = 3;
            this.picFindPerson.TabStop = false;
            this.picFindPerson.Click += new System.EventHandler(this.picFindPerson_Click);
            // 
            // tbFindPerson
            // 
            this.tbFindPerson.Location = new System.Drawing.Point(386, 23);
            this.tbFindPerson.Name = "tbFindPerson";
            this.tbFindPerson.Size = new System.Drawing.Size(290, 24);
            this.tbFindPerson.TabIndex = 2;
            // 
            // cbFindPerson
            // 
            this.cbFindPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindPerson.FormattingEnabled = true;
            this.cbFindPerson.Items.AddRange(new object[] {
            "National No"});
            this.cbFindPerson.Location = new System.Drawing.Point(87, 23);
            this.cbFindPerson.Name = "cbFindPerson";
            this.cbFindPerson.Size = new System.Drawing.Size(293, 24);
            this.cbFindPerson.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By";
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Filter";
            this.Size = new System.Drawing.Size(953, 72);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFindPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFindPerson;
        private System.Windows.Forms.ComboBox cbFindPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picFindPerson;
        private System.Windows.Forms.PictureBox picAddPerson;
    }
}
