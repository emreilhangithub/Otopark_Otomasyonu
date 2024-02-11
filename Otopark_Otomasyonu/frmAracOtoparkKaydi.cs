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
    public partial class frmAracOtoparkKaydi : Form
    {
        public frmAracOtoparkKaydi()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void frmAracOtoparkKaydi_Load(object sender, EventArgs e)
        {
            bosAraclar();
            markaGetir();

        }

        private void markaGetir()
        {
            try
            {
                cmbMarka.Items.Clear();
                SqlCommand komut = new SqlCommand("Select marka from Tbl_Markalar", bgl.baglanti());
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read()) //Kayıtlar okundugu sürece bu işlemi yap
                {
                    cmbMarka.Items.Add(read["marka"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        public void bosAraclar()
        {
            try
            {
                cmbParkYeri.Items.Clear();
                SqlCommand komut = new SqlCommand("Select * from Tbl_Otopark_Durumu where durumu='BOŞ'", bgl.baglanti());
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read()) //Kayıtlar okundugu sürece bu işlemi yap
                {
                    cmbParkYeri.Items.Add(read["parkyeri"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTc.Text) || string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(txtTelefon.Text) || string.IsNullOrEmpty(txtMail.Text))
                {
                    MessageBox.Show("Lütfen Kişi Bilgilerini Eksiksiz Bir Şekilde Doldurunuz");
                    return;
                }

                if (string.IsNullOrEmpty(txtPlaka.Text) || string.IsNullOrEmpty(cmbMarka.Text) || string.IsNullOrEmpty(cmbSeri.Text) || string.IsNullOrEmpty(txtRenk.Text) || string.IsNullOrEmpty(cmbParkYeri.Text)
                   )
                {
                    MessageBox.Show("Lütfen Tüm Araç Bilgilerini Eksiksiz Bir Şekilde Doldurunuz");
                    return;
                }

                SqlCommand kayitkomutu = new SqlCommand("insert into Tbl_Arac_Kaydi (tc,ad,soyad,telefon,mail,plaka,marka,seri,renk,parkyeri,tarih) values(@tc,@ad,@soyad,@telefon,@mail,@plaka,@marka,@seri,@renk,@parkyeri,@tarih)", bgl.baglanti());
                kayitkomutu.Parameters.AddWithValue("@tc", txtTc.Text);
                kayitkomutu.Parameters.AddWithValue("@ad", txtAd.Text);
                kayitkomutu.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                kayitkomutu.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                kayitkomutu.Parameters.AddWithValue("@mail", txtMail.Text);
                kayitkomutu.Parameters.AddWithValue("@plaka", txtPlaka.Text);
                kayitkomutu.Parameters.AddWithValue("@marka", cmbMarka.Text);
                kayitkomutu.Parameters.AddWithValue("@seri", cmbSeri.Text);
                kayitkomutu.Parameters.AddWithValue("@renk", txtRenk.Text);
                kayitkomutu.Parameters.AddWithValue("@parkyeri", cmbParkYeri.Text);
                kayitkomutu.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                kayitkomutu.ExecuteNonQuery();

                SqlCommand guncellemkomutu = new SqlCommand("UPDATE Tbl_Otopark_Durumu set durumu = 'DOLU' where parkyeri=@parkyeri", bgl.baglanti());
                guncellemkomutu.Parameters.AddWithValue("@parkyeri", cmbParkYeri.SelectedItem);
                guncellemkomutu.ExecuteNonQuery();


                bgl.baglanti().Close();
                MessageBox.Show("Personel Başarıyla Eklendi");
                //cmbParkYeri.Items.Clear();
                bosAraclar();
                markaGetir();
                cmbSeri.Items.Clear();

                foreach (Control item in grpKisiBilgileri.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }

                foreach (Control item in grpAracBilgileri.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }

                foreach (Control item in grpAracBilgileri.Controls)
                {
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }          

        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
            markaGetir();//bunu yazmak zorundayız
        }

        private void btnSeri_Click(object sender, EventArgs e)
        {
            frmSeri seri = new frmSeri();
            seri.ShowDialog();
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbSeri.Items.Clear();
                cmbSeri.Text = "";
                SqlCommand komut = new SqlCommand("Select seri from Tbl_Seriler where marka=@marka", bgl.baglanti());
                komut.Parameters.AddWithValue("@marka", cmbMarka.SelectedItem);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read()) //Kayıtlar okundugu sürece bu işlemi yap
                {
                    cmbSeri.Items.Add(read["seri"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }            
        }
    }
}
