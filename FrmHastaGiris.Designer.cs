namespace HastaneRandevu
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.LnkLblÜye = new System.Windows.Forms.LinkLabel();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C Kimlik Numarası:";
            // 
            // LnkLblÜye
            // 
            this.LnkLblÜye.AutoSize = true;
            this.LnkLblÜye.Location = new System.Drawing.Point(417, 148);
            this.LnkLblÜye.Name = "LnkLblÜye";
            this.LnkLblÜye.Size = new System.Drawing.Size(89, 26);
            this.LnkLblÜye.TabIndex = 4;
            this.LnkLblÜye.TabStop = true;
            this.LnkLblÜye.Text = "Kayıt Ol";
            this.LnkLblÜye.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblÜye_LinkClicked);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(223, 142);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(178, 32);
            this.TxtSifre.TabIndex = 2;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(223, 81);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(178, 32);
            this.mskTc.TabIndex = 1;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(288, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta Giriş Alanı";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(12, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 32);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(539, 281);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.LnkLblÜye);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "Hasta Üye Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LnkLblÜye;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}