using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAracOtoparkKayit_Click(object sender, EventArgs e)
        {
            frmAracOtoparkKaydi kayit = new frmAracOtoparkKaydi();
            kayit.ShowDialog();
        }

        private void btnAracOtoparkYerleri_Click(object sender, EventArgs e)
        {
            frmAracOtoparkYerleri kayit = new frmAracOtoparkYerleri();
            kayit.ShowDialog();
        }

        private void btnAracOtoparkCikis_Click(object sender, EventArgs e)
        {
            frmAracOtoparkCikis cikis = new frmAracOtoparkCikis();
            cikis.ShowDialog();
        }

        private void btnOtoparkCikisYapmisAraclar_Click(object sender, EventArgs e)
        {
            frmOtoparkCikisYapmisAraclar cikisYapmisAraclar = new frmOtoparkCikisYapmisAraclar();
            cikisYapmisAraclar.ShowDialog();
        }
    }
}
