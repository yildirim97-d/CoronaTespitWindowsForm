﻿namespace _028_2_WindowsForms
{
    partial class YardimForm
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
            this.linkCovid19 = new System.Windows.Forms.LinkLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yardım için aşağıdaki linke tıklayınız.";
            // 
            // linkCovid19
            // 
            this.linkCovid19.AutoSize = true;
            this.linkCovid19.Location = new System.Drawing.Point(12, 31);
            this.linkCovid19.Name = "linkCovid19";
            this.linkCovid19.Size = new System.Drawing.Size(204, 13);
            this.linkCovid19.TabIndex = 1;
            this.linkCovid19.TabStop = true;
            this.linkCovid19.Text = "T.C. Sağlık Bakanlığı Covid-19 Web Sitesi";
            this.linkCovid19.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCovid19_LinkClicked);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(15, 57);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(957, 692);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.Visible = false;
            // 
            // YardimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.linkCovid19);
            this.Controls.Add(this.label1);
            this.Name = "YardimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yardım";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkCovid19;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}