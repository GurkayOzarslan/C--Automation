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

namespace GYM
{
    public partial class GirisEkran : Form
    {
        public GirisEkran()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=GURAYMARK-XII\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GYMAd_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string sorgu = "Select * from Giris where PerKullanıcı=@kullanıcı and PerSifre=@sifre ";
            cmd=new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@kullanıcı", GirisTB.Text);
            cmd.Parameters.AddWithValue("@sifre", SifreTB.Text);
            baglanti.Open();
            dr = cmd.ExecuteReader();

            if (GirisTB.Text == "" || SifreTB.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girildi");

            }
            else if (GirisTB.Text == "admin" && SifreTB.Text == "1234")
            {
                AdminPanel ap = new AdminPanel();
                ap.Show();
                this.Hide();

            }
            else if (dr.Read())
            {
                AnaSayfa anasayfa = new AnaSayfa();
                anasayfa.Show();
                this.Hide();
            }
            
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!!!");
            }
            baglanti.Close();


        }
        

        private void Reset_Click(object sender, EventArgs e)
        {
            GirisTB.Text = "";
            SifreTB.Text = "";

        }

        private void GirisEkran_Load(object sender, EventArgs e)
        {

        }

        private void Lock_Click(object sender, EventArgs e)
        {

        }

        private void SifreTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
