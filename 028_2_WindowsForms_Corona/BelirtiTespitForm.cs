using System;
using System.Windows.Forms;

namespace _028_2_WindowsForms
{
    public partial class BelirtiTespitForm : Form
    {
        private string[] sehirler = new string[]
        {
            "Ankara",
            "İstanbul",
            "İzmir"
        };

        public BelirtiTespitForm()
        {
            InitializeComponent();
        }

        private void BelirtiTespitForm_Load(object sender, EventArgs e)
        {
            dtpTarih.Value = DateTime.Now;

            //foreach (var sehir in sehirler)
            //{
            //    cbSehir.Items.Add(sehir);
            //}
            cbSehir.Items.AddRange(sehirler);
            
            cbSehir.SelectedIndex = 1;
            tbAdSoyad.Focus();
        }

        private void cbAtes_CheckedChanged(object sender, EventArgs e)
        {
            KontrolEt();
        }

        private void cbOksuruk_CheckedChanged(object sender, EventArgs e)
        {
            KontrolEt();
        }

        private void cbBogazAgrisi_CheckedChanged(object sender, EventArgs e)
        {
            KontrolEt();
        }

        void KontrolEt()
        {
            if (rbKadin.Checked)
            {
                tbSonuc.Text = "Bayan ";
            }
            if (rbErkek.Checked)
            {
                tbSonuc.Text = "Bay ";
            }
            tbSonuc.Text += tbAdSoyad.Text + "\r\n";
            tbSonuc.Text += "Bulunduğunuz şehir " + cbSehir.Text + "\r\n";
            tbSonuc.Text += "Yaşınız " + nudYas.Value + "\r\n";
            tbSonuc.Text += "Kontrol tarihi " + dtpTarih.Value.ToShortDateString() + "\r\n";
            if (cbAtes.Checked || (cbOksuruk.Checked && cbBogazAgrisi.Checked))
            {
                tbSonuc.Text += "\"Koronavirus olabilirsiniz.\"";
            }
            else
            {
                tbSonuc.Text += "\"Koronavirus olmayabilirsiniz.\"";
            }
        }
    }
}
