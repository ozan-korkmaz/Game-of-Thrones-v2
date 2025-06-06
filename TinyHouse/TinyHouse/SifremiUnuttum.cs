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

namespace TinyHouse
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void btnYeniSifreKaydet_Click(object sender, EventArgs e)
        {
            if (mskYeniSifre.Text == mskYeniSifreTekrar.Text)
            {
                SqlCommand yeniSifre = new SqlCommand("UPDATE Users SET Password=@yeniSifre WHERE Email=@email", bgl.baglanti());
                yeniSifre.Parameters.AddWithValue("@email",txtYSKullaniciAdi.Text);
                yeniSifre.Parameters.AddWithValue("@yeniSifre", mskYeniSifre.Text);                
                yeniSifre.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Şifreniz Başarıyla Değiştirildi!");
            }
            else
            {
                MessageBox.Show("Şifreler aynı değil!");
            }
        }
    }
}
