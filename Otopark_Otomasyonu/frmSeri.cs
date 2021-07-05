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
    public partial class frmSeri : Form
    {
        public frmSeri()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand kayitkomutu = new SqlCommand("insert into Tbl_Seriler (marka,seri) values(@marka,@seri)", bgl.baglanti());
            kayitkomutu.Parameters.AddWithValue("@seri", txtSeri.Text);
            kayitkomutu.Parameters.AddWithValue("@marka", cmbMarka.Text);
            kayitkomutu.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Markaya baglı araç serisi eklendi");
            txtSeri.Clear();
            cmbMarka.Text = "";
            cmbMarka.Items.Clear();
            marka();
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand("Select marka,seri from Tbl_Markalar", bgl.baglanti());
            //SqlDataReader read = komut.ExecuteReader();
            //while (read.Read()) //Kayıtlar okundugu sürece bu işlemi yap
            //{
            //    cmbMarka.Items.Add(read["marka"].ToString());
            //}
        }

        private void frmSeri_Load(object sender, EventArgs e)
        {
            marka();
        }

        private void marka()
        {
            SqlCommand komut = new SqlCommand("Select marka from Tbl_Markalar", bgl.baglanti());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()) //Kayıtlar okundugu sürece bu işlemi yap
            {
                cmbMarka.Items.Add(read["marka"].ToString());
            }
        }
    }
}
