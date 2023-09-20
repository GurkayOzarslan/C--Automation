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
    public partial class PersonelBilgi : Form
    {
        public PersonelBilgi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=GURAYMARK-XII\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        private void Fillname()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select PerAdSoyad from Personel ", baglanti);
            SqlDataReader oku;
            oku = komut.ExecuteReader();
            DataTable tablo = new DataTable();
            tablo.Columns.Add("PerAdSoyad", typeof(string));
            tablo.Load(oku);
            AdSoyadCB.ValueMember = "PerAdSoyad";
            AdSoyadCB.DataSource = tablo;
            baglanti.Close();
        }
        private void AdFiltrele()
        {
            baglanti.Open();
            string query = "select*from Giris where PerAd='" + AraTB.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dataset = new DataSet();
            sda.Fill(dataset);
            OdemeData.DataSource = dataset.Tables[0];
            baglanti.Close();

        }
        private void personel()
        {
            baglanti.Open();
            string query = "select*from Giris";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dataset = new DataSet();
            sda.Fill(dataset);
            OdemeData.DataSource = dataset.Tables[0];
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();
        }

        private void PersonelBilgi_Load(object sender, EventArgs e)
        {
            Fillname();
            personel();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void AraBT_Click(object sender, EventArgs e)
        {
            AdFiltrele();
            AraTB.Text = "";
        }

        private void Yenile_Click(object sender, EventArgs e)
        {
            personel();
        }

        private void KaydetBT_Click(object sender, EventArgs e)
        {
            if (AdSoyadCB.Text == "" || SifreTB.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Var");
            }
            else
            {
                
                baglanti.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from Giris where PerAd='" + AdSoyadCB.SelectedValue.ToString() + "'and PerKullanıcı='" + KullanıcıTB.Text + "'and PerSifre='"+SifreTB.Text+"'", baglanti);
                DataTable tablo = new DataTable();
                sda.Fill(tablo);
                if (tablo.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Zaten Kullanıcıya Şifre Ataması Yapıldı");

                }
                else
                {
                    string query = "insert into Giris values ('" + KullanıcıTB.Text + "','" + SifreTB.Text+ "','" +AdSoyadCB.SelectedValue.ToString() + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Sifre Atama İşlemi Başarıyla Yapılmıştır!");

                }
                baglanti.Close();
                personel();





            }
        }

        private void AdSoyadCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GeriBT_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();
        }
    }
}
