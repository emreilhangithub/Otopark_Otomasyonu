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
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand kayitkomutu = new SqlCommand("insert into Tbl_Markalar (marka) values(@marka)", bgl.baglanti());
                kayitkomutu.Parameters.AddWithValue("@marka", txtMarka.Text);
                kayitkomutu.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Marka Başarıyla Eklendi");
                txtMarka.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }         

            //frmAracOtoparkKaydi aracKaydi = new frmAracOtoparkKaydi();
            //aracKaydi.markaGetir();
        }
    }
}
