using System;
using System.Windows.Forms;

namespace _028_2_WindowsForms
{
    public partial class KoronavirusTespitForm : Form
    {
        public KoronavirusTespitForm()
        {
            InitializeComponent();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YardimForm yardimForm = new YardimForm();
            yardimForm.Show();
        }

        private void belirtiTespitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BelirtiTespitForm belirtiTespitForm = new BelirtiTespitForm();
            belirtiTespitForm.MdiParent = this;
            belirtiTespitForm.WindowState = FormWindowState.Maximized;
            belirtiTespitForm.Focus();
            belirtiTespitForm.Show();
        }

        private void yüzdeTespitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YuzdeTespitForm yuzdeTespitForm = new YuzdeTespitForm();
            yuzdeTespitForm.MdiParent = this;
            yuzdeTespitForm.WindowState = FormWindowState.Maximized;
            yuzdeTespitForm.Focus();
            yuzdeTespitForm.Show();
        }

        private void KoronavirusTespitForm_Load(object sender, EventArgs e)
        {
            HosgeldinForm hosgeldinForm = new HosgeldinForm();
            hosgeldinForm.MdiParent = this;
            hosgeldinForm.WindowState = FormWindowState.Maximized;
            hosgeldinForm.Focus();
            hosgeldinForm.Show();
        }
    }
}
