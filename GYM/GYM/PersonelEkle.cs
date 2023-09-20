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
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=GURAYMARK-XII\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
           
        }

        private void EkleBt_Click(object sender, EventArgs e)
        {
            if (PerAdSoyadTB.Text == "" || PerTelefonTB.Text == "" || PerMaasTB.Text == ""||CinsiyetCB.ToString()=="")
            {
                MessageBox.Show("Eksik Bilgi(ler) Girilmiştir");

            }


            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into Personel values('" + PerAdSoyadTB.Text + "','" + PerTelefonTB.Text + "','" + PerMaasTB.Text + "', '" +CinsiyetCB.SelectedItem.ToString()+"')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Personel Ekleme Başarılı");
                    baglanti.Close();
                    PerAdSoyadLB.Text = "";
                    PerTelefonTB.Text = "";
                    PerMaasTB.Text = "";


                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }

            }
        }

        private void GeriBT_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
