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
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=GURAYMARK-XII\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UyeEkle_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (UyeAdSoyadTB.Text == "" || UyeTelefonTB.Text == "" || UyeOdemeTB.Text == "" || UyeYasTB.Text == "")
            {
                MessageBox.Show("Eksik Bilgi(ler) Girilmiştir");

            }


            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into Uyeler values('" + UyeAdSoyadTB.Text + "','" + UyeTelefonTB.Text + "','" + UyeYasTB.Text + "','" + CinsiyetCB.SelectedItem.ToString() + "','" + UyeOdemeTB.Text + "' )";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Ekleme Başarılı");
                    baglanti.Close();
                    UyeAdSoyadTB.Text = "";
                    UyeTelefonTB.Text = "";
                    UyeYas.Text = "";
                    CinsiyetCB.Text = "";
                    UyeOdemeTB.Text = "";
                    

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }

            }



        }

        private void CinsiyetCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

