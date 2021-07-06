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
    public partial class frmAracOtoparkCikis : Form
    {
        public frmAracOtoparkCikis()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void frmAracOtoparkCikis_Load(object sender, EventArgs e)
        {
            doluYerler();
            plakalar();

            timer1.Enabled = true;

        }

        private void plakalar()
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Arac_Kaydi", bgl.baglanti());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbPlakaAra.Items.Add(read["plaka"].ToString());
            }
        }

        private void doluYerler()
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Otopark_Durumu where durumu= 'DOLU' ", bgl.baglanti());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbParkYeri.Items.Add(read["parkyeri"].ToString());
            }
        }

        private void cmbPlakaAra_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Arac_Kaydi where plaka=@plaka", bgl.baglanti());
            komut.Parameters.AddWithValue("@plaka", cmbPlakaAra.SelectedItem);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtParkYeri.Text=read["parkyeri"].ToString();
            }
        }

        private void cmbParkYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Arac_Kaydi where parkyeri=@parkyeri", bgl.baglanti());
            komut.Parameters.AddWithValue("@parkyeri", cmbParkYeri.SelectedItem);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtParkYeri2.Text = read["parkyeri"].ToString();
                txtTc.Text = read["tc"].ToString();
                txtAd.Text = read["ad"].ToString();
                txtSoyad.Text = read["soyad"].ToString();
                txtMarka.Text = read["marka"].ToString();
                txtSeri.Text = read["seri"].ToString();
                txtRenk.Text = read["renk"].ToString();
                txtPlaka.Text = read["plaka"].ToString();
                lblGelisTarihi.Text = read["tarih"].ToString();
            }
            DateTime gelis, cikis;
            gelis = DateTime.Parse(lblGelisTarihi.Text);
            cikis = DateTime.Parse(lblCikisTarihi.Text);
            TimeSpan fark; //aradaki fark için
            fark = cikis - gelis;
            lblSure.Text = fark.TotalHours.ToString("0.00");//2 basamaklı gosterdik virgülden sonra
            lblToplamTutar.Text = (double.Parse(lblSure.Text) * (0.75)).ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCikisTarihi.Text = DateTime.Now.ToString(); //şimdiki tarih ve zmanı göster orada
        }

        private void btnAracCikisi_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Arac_Kaydi where plaka=@plaka", bgl.baglanti());
            komut.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut.ExecuteNonQuery();

            SqlCommand komut2 = new SqlCommand("update Tbl_Otopark_Durumu set durumu='BOS' where parkyeri=@parkyeri", bgl.baglanti());
            komut2.Parameters.AddWithValue("@parkyeri", txtParkYeri2.Text);
            komut2.ExecuteNonQuery();
            MessageBox.Show("Araç Çıkışı yapıldı");

            foreach (Control item in grpAracBilgileri.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    txtParkYeri.Text = "";
                    cmbPlakaAra.Text = "";
                    cmbParkYeri.Text = "";
                }
            }
            cmbPlakaAra.Items.Clear();
            cmbParkYeri.Items.Clear();
            doluYerler();
            plakalar();



        }


        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
