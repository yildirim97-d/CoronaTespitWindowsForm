using System.Windows.Forms;

namespace _028_2_WindowsForms
{
    public partial class YuzdeTespitForm : Form
    {
        public YuzdeTespitForm()
        {
            InitializeComponent();
        }

        private void bHesapla_Click(object sender, System.EventArgs e)
        {
            string sonuc;
            int yuzde = 0;
            if (cbAtes.Checked)
                yuzde += 70;
            if (cbOksuruk.Checked)
                yuzde += 20;
            if (cbBogazAgrisi.Checked)
                yuzde += 10;
            sonuc = "Sayın " + tbAdSoyad.Text + ", ";
            sonuc += "Koronavirus olma ihtimaliniz %" + yuzde;
            lbSonuc.Items.Add(sonuc);
        }

        private void bTemizle_Click(object sender, System.EventArgs e)
        {
            tbAdSoyad.Text = "";
            cbAtes.Checked = false;
            cbOksuruk.Checked = false;
            cbBogazAgrisi.Checked = false;
            lbSonuc.Items.Clear();
            rtbRapor.Text = "";
            gbRapor.Visible = false;
        }

        private void bRapor_Click(object sender, System.EventArgs e)
        {
            rtbRapor.Text = "";
            if (lbSonuc.Items.Count > 0)
            {
                foreach (var item in lbSonuc.Items)
                {
                    rtbRapor.Text += item + "\r\n";
                }
                gbRapor.Visible = true;
            }
        }
    }
}
