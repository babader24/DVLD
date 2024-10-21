namespace DVLD
{
    partial class frmPersonDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.personInfo = new DVLD.PersonInfo();
            this.Closebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(260, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show Person Infomations";
            // 
            // personInfo
            // 
            this.personInfo._ID = 0;
            this.personInfo.Location = new System.Drawing.Point(12, 98);
            this.personInfo.Name = "personInfo";
            this.personInfo.Size = new System.Drawing.Size(961, 340);
            this.personInfo.TabIndex = 0;
            // 
            // Closebtn
            // 
            this.Closebtn.BackColor = System.Drawing.Color.White;
            this.Closebtn.BackgroundImage = global::DVLD.Properties.Resources.close_pane_320px;
            this.Closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Closebtn.Location = new System.Drawing.Point(802, 377);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(104, 43);
            this.Closebtn.TabIndex = 10;
            this.Closebtn.UseVisualStyleBackColor = false;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPersonDetails";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "frmPersonDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PersonInfo personInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Closebtn;
    }
}