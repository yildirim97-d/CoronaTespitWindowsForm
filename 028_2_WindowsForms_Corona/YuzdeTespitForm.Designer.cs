namespace _028_2_WindowsForms
{
    partial class YuzdeTespitForm
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
            this.tbAdSoyad = new System.Windows.Forms.TextBox();
            this.gbBelirtiler = new System.Windows.Forms.GroupBox();
            this.cbBogazAgrisi = new System.Windows.Forms.CheckBox();
            this.cbOksuruk = new System.Windows.Forms.CheckBox();
            this.cbAtes = new System.Windows.Forms.CheckBox();
            this.bHesapla = new System.Windows.Forms.Button();
            this.bTemizle = new System.Windows.Forms.Button();
            this.bRapor = new System.Windows.Forms.Button();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.gbRapor = new System.Windows.Forms.GroupBox();
            this.rtbRapor = new System.Windows.Forms.RichTextBox();
            this.gbBelirtiler.SuspendLayout();
            this.gbRapor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad";
            // 
            // tbAdSoyad
            // 
            this.tbAdSoyad.Location = new System.Drawing.Point(68, 12);
            this.tbAdSoyad.Name = "tbAdSoyad";
            this.tbAdSoyad.Size = new System.Drawing.Size(300, 20);
            this.tbAdSoyad.TabIndex = 3;
            // 
            // gbBelirtiler
            // 
            this.gbBelirtiler.Controls.Add(this.cbBogazAgrisi);
            this.gbBelirtiler.Controls.Add(this.cbOksuruk);
            this.gbBelirtiler.Controls.Add(this.cbAtes);
            this.gbBelirtiler.Location = new System.Drawing.Point(12, 38);
            this.gbBelirtiler.Name = "gbBelirtiler";
            this.gbBelirtiler.Size = new System.Drawing.Size(382, 101);
            this.gbBelirtiler.TabIndex = 6;
            this.gbBelirtiler.TabStop = false;
            this.gbBelirtiler.Text = "Belirtiler";
            // 
            // cbBogazAgrisi
            // 
            this.cbBogazAgrisi.AutoSize = true;
            this.cbBogazAgrisi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbBogazAgrisi.Location = new System.Drawing.Point(9, 74);
            this.cbBogazAgrisi.Name = "cbBogazAgrisi";
            this.cbBogazAgrisi.Size = new System.Drawing.Size(84, 17);
            this.cbBogazAgrisi.TabIndex = 2;
            this.cbBogazAgrisi.Text = "Boğaz Ağrısı";
            this.cbBogazAgrisi.UseVisualStyleBackColor = true;
            // 
            // cbOksuruk
            // 
            this.cbOksuruk.AutoSize = true;
            this.cbOksuruk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbOksuruk.Location = new System.Drawing.Point(9, 51);
            this.cbOksuruk.Name = "cbOksuruk";
            this.cbOksuruk.Size = new System.Drawing.Size(66, 17);
            this.cbOksuruk.TabIndex = 1;
            this.cbOksuruk.Text = "Öksürük";
            this.cbOksuruk.UseVisualStyleBackColor = true;
            // 
            // cbAtes
            // 
            this.cbAtes.AutoSize = true;
            this.cbAtes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAtes.Location = new System.Drawing.Point(9, 28);
            this.cbAtes.Name = "cbAtes";
            this.cbAtes.Size = new System.Drawing.Size(47, 17);
            this.cbAtes.TabIndex = 0;
            this.cbAtes.Text = "Ateş";
            this.cbAtes.UseVisualStyleBackColor = true;
            // 
            // bHesapla
            // 
            this.bHesapla.Location = new System.Drawing.Point(12, 145);
            this.bHesapla.Name = "bHesapla";
            this.bHesapla.Size = new System.Drawing.Size(75, 23);
            this.bHesapla.TabIndex = 7;
            this.bHesapla.Text = "Hesapla";
            this.bHesapla.UseVisualStyleBackColor = true;
            this.bHesapla.Click += new System.EventHandler(this.bHesapla_Click);
            // 
            // bTemizle
            // 
            this.bTemizle.Location = new System.Drawing.Point(93, 145);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(75, 23);
            this.bTemizle.TabIndex = 7;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.UseVisualStyleBackColor = true;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // bRapor
            // 
            this.bRapor.Location = new System.Drawing.Point(174, 145);
            this.bRapor.Name = "bRapor";
            this.bRapor.Size = new System.Drawing.Size(75, 23);
            this.bRapor.TabIndex = 7;
            this.bRapor.Text = "Rapor";
            this.bRapor.UseVisualStyleBackColor = true;
            this.bRapor.Click += new System.EventHandler(this.bRapor_Click);
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.Location = new System.Drawing.Point(12, 174);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbSonuc.Size = new System.Drawing.Size(382, 212);
            this.lbSonuc.TabIndex = 8;
            // 
            // gbRapor
            // 
            this.gbRapor.Controls.Add(this.rtbRapor);
            this.gbRapor.Location = new System.Drawing.Point(12, 392);
            this.gbRapor.Name = "gbRapor";
            this.gbRapor.Size = new System.Drawing.Size(382, 257);
            this.gbRapor.TabIndex = 9;
            this.gbRapor.TabStop = false;
            this.gbRapor.Text = "Rapor";
            this.gbRapor.Visible = false;
            // 
            // rtbRapor
            // 
            this.rtbRapor.Location = new System.Drawing.Point(7, 20);
            this.rtbRapor.Name = "rtbRapor";
            this.rtbRapor.Size = new System.Drawing.Size(369, 231);
            this.rtbRapor.TabIndex = 0;
            this.rtbRapor.Text = "";
            // 
            // YuzdeTespitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.gbRapor);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.bRapor);
            this.Controls.Add(this.bTemizle);
            this.Controls.Add(this.bHesapla);
            this.Controls.Add(this.gbBelirtiler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAdSoyad);
            this.Name = "YuzdeTespitForm";
            this.Text = "Yüzde Tespit";
            this.gbBelirtiler.ResumeLayout(false);
            this.gbBelirtiler.PerformLayout();
            this.gbRapor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAdSoyad;
        private System.Windows.Forms.GroupBox gbBelirtiler;
        private System.Windows.Forms.CheckBox cbBogazAgrisi;
        private System.Windows.Forms.CheckBox cbOksuruk;
        private System.Windows.Forms.CheckBox cbAtes;
        private System.Windows.Forms.Button bHesapla;
        private System.Windows.Forms.Button bTemizle;
        private System.Windows.Forms.Button bRapor;
        private System.Windows.Forms.ListBox lbSonuc;
        private System.Windows.Forms.GroupBox gbRapor;
        private System.Windows.Forms.RichTextBox rtbRapor;
    }
}