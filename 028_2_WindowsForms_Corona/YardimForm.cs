using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace _028_2_WindowsForms
{
    public partial class YardimForm : Form
    {
        public YardimForm()
        {
            InitializeComponent();
        }

        private void linkCovid19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser1.Url = new Uri("https://covid19.saglik.gov.tr");
            webBrowser1.Visible = true;

            Process.Start("chrome.exe", "https://saglik.gov.tr/");
        }
    }
}
