namespace DVLD
{
    partial class frmInternationalDriverInfo
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
            this.ucInternationalDriverInfo1 = new DVLD.ucInternationalDriverInfo();
            this.btnClose = new System.Windows.Forms.Button();
            this.lTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucInternationalDriverInfo1
            // 
            this.ucInternationalDriverInfo1._ID = 0;
            this.ucInternationalDriverInfo1.Location = new System.Drawing.Point(10, 155);
            this.ucInternationalDriverInfo1.Name = "ucInternationalDriverInfo1";
            this.ucInternationalDriverInfo1.Size = new System.Drawing.Size(1028, 370);
            this.ucInternationalDriverInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = global::DVLD.Properties.Resources.close_pane_320px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Location = new System.Drawing.Point(873, 524);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 43);
            this.btnClose.TabIndex = 46;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lTitle.Location = new System.Drawing.Point(221, 117);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(533, 35);
            this.lTitle.TabIndex = 47;
            this.lTitle.Text = "Driver International License Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.smart_card_480px;
            this.pictureBox1.Location = new System.Drawing.Point(369, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // frmInternationalDriverInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 579);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucInternationalDriverInfo1);
            this.Name = "frmInternationalDriverInfo";
            this.Text = "frmInternationalDriverInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucInternationalDriverInfo ucInternationalDriverInfo1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}