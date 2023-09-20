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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=GURAYMARK-XII\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        private void Fillname()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select UyeAdSoyad from Uyeler ", baglanti);
            SqlDataReader oku;
            oku = komut.ExecuteReader();
            DataTable tablo = new DataTable();
            tablo.Columns.Add("UyeAdSoyad", typeof(string));
            tablo.Load(oku);
            AdSoyadCB.ValueMember = "UyeAdSoyad";
            AdSoyadCB.DataSource = tablo;
            baglanti.Close();
        }
        private void AdFiltrele()
        {
            baglanti.Open();
            string query = "select*from Odeme where OdeUye='"+AraTB.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dataset = new DataSet();
            sda.Fill(dataset);
            OdemeData.DataSource = dataset.Tables[0];
            baglanti.Close();

        }
        private void uyeler()
        {
            baglanti.Open();
            string query = "select*from Odeme";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dataset = new DataSet();
            sda.Fill(dataset);
            OdemeData.DataSource = dataset.Tables[0];
            baglanti.Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Hide();

                
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            Fillname();
            uyeler();

             
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (AdSoyadCB.Text=="" ||TutarTB.Text=="")
            {
                MessageBox.Show("Eksik Bilgi Var");
            }
            else
            {
                string odemeperiyot = Periyot.Value.Month.ToString() + Periyot.Value.Year.ToString();
                baglanti.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from odeme where OdeUye='"+AdSoyadCB.SelectedValue.ToString()+"'and OdeAy='"+odemeperiyot+"'",baglanti);
                DataTable tablo = new DataTable();
                sda.Fill(tablo);
                if (tablo.Rows[0][0].ToString()=="1")
                {
                    MessageBox.Show("Zaten Ödeme Yapıldı");

                }
                else
                {
                    string query = "insert into Odeme values ('" + odemeperiyot + "','" + AdSoyadCB.SelectedValue.ToString()+"','"+TutarTB.Text+"')";
                    SqlCommand komut = new SqlCommand(query,baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Ödeme Başarıyla Yapılmıştır!");

                }
                baglanti.Close();
                uyeler();





            }
        }

        private void AraBT_Click(object sender, EventArgs e)
        {
            AdFiltrele();
            AraTB.Text = "";
        }

        private void Yenile_Click(object sender, EventArgs e)
        {
            uyeler();

        }

        private void OdemeData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
