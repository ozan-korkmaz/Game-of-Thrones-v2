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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand login = new SqlCommand("select Email,Password,Role from Users where Email=@email and Password=@sifre", bgl.baglanti());
            login.Parameters.AddWithValue("@email", txtKullaniciAdi.Text);
            login.Parameters.AddWithValue("@sifre", mskSifre.Text);
            SqlDataReader reader = login.ExecuteReader();
            
            if (reader.Read())
            {
                string role = reader["Role"].ToString();

                if (role == "Admin")
                {
                    AdminAnaSayfa adm = new AdminAnaSayfa();
                    adm.Show();
                    this.Hide();
                }
                else if (role == "Ev Sahibi")
                {
                    EvSahibiAnaSayfa evsahibi = new EvSahibiAnaSayfa();
                    evsahibi.Show();
                    this.Hide();
                }
                else if (role == "Kiraci")
                {
                    KiraciAnaSayfa kiraci = new KiraciAnaSayfa();
                    kiraci.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bilinmeyen rol.");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                bgl.baglanti().Close();
            
        }

        private void linkLabelUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UyeOl uyeOl = new UyeOl();
            uyeOl.Show();
        }

        private void linkLabelSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum unuttum = new SifremiUnuttum();
            unuttum.Show();
        }
    }
}
