namespace DVLD
{
    partial class frmAddEdit
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
            this.ucAddEdit1 = new DVLD.ucAddEdit();
            this.SuspendLayout();
            // 
            // ucAddEdit1
            // 
            this.ucAddEdit1.ID = 0;
            this.ucAddEdit1.Location = new System.Drawing.Point(2, -7);
            this.ucAddEdit1.Name = "ucAddEdit1";
            this.ucAddEdit1.Size = new System.Drawing.Size(919, 478);
            this.ucAddEdit1.TabIndex = 0;
            // 
            // frmAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 480);
            this.Controls.Add(this.ucAddEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEdit";
            this.Text = "frmAddEdit";
            this.ResumeLayout(false);

        }

        #endregion

        private ucAddEdit ucAddEdit1;
    }
}