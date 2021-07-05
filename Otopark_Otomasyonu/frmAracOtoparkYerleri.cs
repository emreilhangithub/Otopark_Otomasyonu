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
    public partial class frmAracOtoparkYerleri : Form
    {
        public frmAracOtoparkYerleri()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void frmAracOtoparkYerleri_Load(object sender, EventArgs e)
        {
            bosParkYerleri();
            doluParkYerleri();

            SqlCommand komut = new SqlCommand("Select * from Tbl_Arac_Kaydi", bgl.baglanti());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()) //Kayıtlar okundugu sürece bu işlemi yap
            {
                foreach (Control item in Controls) //formdaki kontrolleri dolas
                {
                    if (item is Button) //itemler buton ise
                    {
                        if (item.Text == read["parkyeri"].ToString()) //eğer veri tabanındaki kayıt ile eşleşiyorsa item 
                        {
                            item.Text = read["parkyeri"].ToString(); //plakayı yaz
                        }

                    }
                }
            }



        }

        private void doluParkYerleri()
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Otopark_Durumu", bgl.baglanti());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()) //Kayıtlar okundugu sürece bu işlemi yap
            {
                foreach (Control item in Controls) //formdaki kontrolleri dolas
                {
                    if (item is Button) //itemler buton ise
                    {
                        if (item.Text == read["parkyeri"].ToString() && read["durumu"].ToString() == "DOLU") //eğer veri tabanındaki kayıt ile eşleşiyorsa item ve durumu dolu ise
                        {
                            item.BackColor = Color.Red;
                        }

                    }
                }
            }
        }

        private void bosParkYerleri()
        {
            int sayac = 1;
            foreach (Control item in Controls) //formdaki contorlleri dolaş
            {
                if (item is Button) //itemler buton ise
                {
                    item.Text = "P-" + sayac;
                    item.Name = "P-" + sayac;
                    sayac++;//dongu her calıstıgında sayac artsın
                }
            }
        }
    }
}
