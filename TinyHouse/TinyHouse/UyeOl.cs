using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyHouse
{
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            if (mskSifre.Text == mskSifreTekrar.Text)
            {
                SqlCommand uyeOl = new SqlCommand("INSERT INTO Users (FullName,Email,Password,Role) VALUES (@adSoyad,@email,@sifre,@rol)", bgl.baglanti());
                uyeOl.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
                uyeOl.Parameters.AddWithValue("@email", txtEmail.Text);
                uyeOl.Parameters.AddWithValue("@sifre", mskSifre.Text);
                uyeOl.Parameters.AddWithValue("@rol", cmbRol.Text);
                uyeOl.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Başarıyla Gerçekleşti");

                Login login = new Login();
                login.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Şifreler Aynı Değil.");
            }
            
            
        }
    }
}
