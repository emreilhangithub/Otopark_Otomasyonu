using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otopark_Otomasyonu
{
    public partial class frmOtoparkCikisYapmisAraclar : Form
    {
        public frmOtoparkCikisYapmisAraclar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void frmOtoparkCikisYapmisAraclar_Load(object sender, EventArgs e)
        {
            satisListesi();
            hesapla();
        }

        private void hesapla()
        {         
            try
            {
                SqlCommand komut = new SqlCommand("Select sum(tutar) from Tbl_Cikislar", bgl.baglanti());
                lblToplamTutar.Text = "Toplam Tutar = " + komut.ExecuteScalar() + "TL";
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void satisListesi()
        {           
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from Tbl_Cikislar", bgl.baglanti());
                adtr.Fill(dt);
                dataGridView1.DataSource = dt;
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
