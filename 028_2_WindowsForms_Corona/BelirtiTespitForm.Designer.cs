namespace _028_2_WindowsForms
{
    partial class BelirtiTespitForm
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
            this.gbKisiselBilgiler = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSehir = new System.Windows.Forms.ComboBox();
            this.nudYas = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.gbBelirtiler = new System.Windows.Forms.GroupBox();
            this.cbAtes = new System.Windows.Forms.CheckBox();
            this.cbOksuruk = new System.Windows.Forms.CheckBox();
            this.cbBogazAgrisi = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSonuc = new System.Windows.Forms.TextBox();
            this.gbKisiselBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYas)).BeginInit();
            this.gbBelirtiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // tbAdSoyad
            // 
            this.tbAdSoyad.Location = new System.Drawing.Point(65, 23);
            this.tbAdSoyad.Name = "tbAdSoyad";
            this.tbAdSoyad.Size = new System.Drawing.Size(300, 20);
            this.tbAdSoyad.TabIndex = 0;
            // 
            // gbKisiselBilgiler
            // 
            this.gbKisiselBilgiler.Controls.Add(this.rbErkek);
            this.gbKisiselBilgiler.Controls.Add(this.rbKadin);
            this.gbKisiselBilgiler.Controls.Add(this.label4);
            this.gbKisiselBilgiler.Controls.Add(this.label3);
            this.gbKisiselBilgiler.Controls.Add(this.nudYas);
            this.gbKisiselBilgiler.Controls.Add(this.cbSehir);
            this.gbKisiselBilgiler.Controls.Add(this.label2);
            this.gbKisiselBilgiler.Controls.Add(this.label1);
            this.gbKisiselBilgiler.Controls.Add(this.tbAdSoyad);
            this.gbKisiselBilgiler.Location = new System.Drawing.Point(12, 12);
            this.gbKisiselBilgiler.Name = "gbKisiselBilgiler";
            this.gbKisiselBilgiler.Size = new System.Drawing.Size(382, 129);
            this.gbKisiselBilgiler.TabIndex = 2;
            this.gbKisiselBilgiler.TabStop = false;
            this.gbKisiselBilgiler.Text = "Kişisel Bilgiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şehir";
            // 
            // cbSehir
            // 
            this.cbSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSehir.FormattingEnabled = true;
            this.cbSehir.Location = new System.Drawing.Point(65, 49);
            this.cbSehir.Name = "cbSehir";
            this.cbSehir.Size = new System.Drawing.Size(300, 21);
            this.cbSehir.TabIndex = 2;
            // 
            // nudYas
            // 
            this.nudYas.Location = new System.Drawing.Point(65, 76);
            this.nudYas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudYas.Name = "nudYas";
            this.nudYas.Size = new System.Drawing.Size(150, 20);
            this.nudYas.TabIndex = 3;
            this.nudYas.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yaş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cinsiyet";
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Checked = true;
            this.rbKadin.Location = new System.Drawing.Point(65, 102);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(52, 17);
            this.rbKadin.TabIndex = 4;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(123, 102);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 5;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tarih";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(437, 35);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(150, 20);
            this.dtpTarih.TabIndex = 1;
            // 
            // gbBelirtiler
            // 
            this.gbBelirtiler.Controls.Add(this.cbBogazAgrisi);
            this.gbBelirtiler.Controls.Add(this.cbOksuruk);
            this.gbBelirtiler.Controls.Add(this.cbAtes);
            this.gbBelirtiler.Location = new System.Drawing.Point(12, 147);
            this.gbBelirtiler.Name = "gbBelirtiler";
            this.gbBelirtiler.Size = new System.Drawing.Size(575, 101);
            this.gbBelirtiler.TabIndex = 5;
            this.gbBelirtiler.TabStop = false;
            this.gbBelirtiler.Text = "Belirtiler (İşaretlemelere göre sonuç yazdırılacaktır)";
            // 
            // cbAtes
            // 
            this.cbAtes.AutoSize = true;
            this.cbAtes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAtes.Location = new System.Drawing.Point(9, 28);
            this.cbAtes.Name = "cbAtes";
            this.cbAtes.Size = new System.Drawing.Size(47, 17);
            this.cbAtes.TabIndex = 6;
            this.cbAtes.Text = "Ateş";
            this.cbAtes.UseVisualStyleBackColor = true;
            this.cbAtes.CheckedChanged += new System.EventHandler(this.cbAtes_CheckedChanged);
            // 
            // cbOksuruk
            // 
            this.cbOksuruk.AutoSize = true;
            this.cbOksuruk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbOksuruk.Location = new System.Drawing.Point(9, 51);
            this.cbOksuruk.Name = "cbOksuruk";
            this.cbOksuruk.Size = new System.Drawing.Size(66, 17);
            this.cbOksuruk.TabIndex = 7;
            this.cbOksuruk.Text = "Öksürük";
            this.cbOksuruk.UseVisualStyleBackColor = true;
            this.cbOksuruk.CheckedChanged += new System.EventHandler(this.cbOksuruk_CheckedChanged);
            // 
            // cbBogazAgrisi
            // 
            this.cbBogazAgrisi.AutoSize = true;
            this.cbBogazAgrisi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbBogazAgrisi.Location = new System.Drawing.Point(9, 74);
            this.cbBogazAgrisi.Name = "cbBogazAgrisi";
            this.cbBogazAgrisi.Size = new System.Drawing.Size(84, 17);
            this.cbBogazAgrisi.TabIndex = 8;
            this.cbBogazAgrisi.Text = "Boğaz Ağrısı";
            this.cbBogazAgrisi.UseVisualStyleBackColor = true;
            this.cbBogazAgrisi.CheckedChanged += new System.EventHandler(this.cbBogazAgrisi_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(9, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sonuç";
            // 
            // tbSonuc
            // 
            this.tbSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSonuc.Location = new System.Drawing.Point(12, 276);
            this.tbSonuc.Multiline = true;
            this.tbSonuc.Name = "tbSonuc";
            this.tbSonuc.ReadOnly = true;
            this.tbSonuc.Size = new System.Drawing.Size(575, 100);
            this.tbSonuc.TabIndex = 9;
            // 
            // BelirtiTespitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.tbSonuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbBelirtiler);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbKisiselBilgiler);
            this.Name = "BelirtiTespitForm";
            this.Text = "Belirti Tespit";
            this.Load += new System.EventHandler(this.BelirtiTespitForm_Load);
            this.gbKisiselBilgiler.ResumeLayout(false);
            this.gbKisiselBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYas)).EndInit();
            this.gbBelirtiler.ResumeLayout(false);
            this.gbBelirtiler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAdSoyad;
        private System.Windows.Forms.GroupBox gbKisiselBilgiler;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudYas;
        private System.Windows.Forms.ComboBox cbSehir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.GroupBox gbBelirtiler;
        private System.Windows.Forms.CheckBox cbBogazAgrisi;
        private System.Windows.Forms.CheckBox cbOksuruk;
        private System.Windows.Forms.CheckBox cbAtes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSonuc;
    }
}