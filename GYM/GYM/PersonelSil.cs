using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GYM
{
    public partial class PersonelSil : Form
    {
        public PersonelSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=GURAYMARK-XII\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        private void uyeler()
        {
            baglanti.Open();
            string query = "select*from Personel";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dataset = new DataSet();
            sda.Fill(dataset);
            PerData.DataSource = dataset.Tables[0];
            baglanti.Close();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void PersonelSil_Load(object sender, EventArgs e)
        {
            uyeler();

        }
        int key = 0;

        private void SilBt_Click(object sender, EventArgs e)
        {
            {
                if (key == 0 || AdSoyadTB.Text == "" || TelTB.Text == "" || MaasTB.Text == "" || CinsiyetCB.Text == "" )
                {
                    MessageBox.Show("Silinecek Üyeyi Seçiniz!!");

                }
                else
                {
                    try
                    {
                        baglanti.Open();
                        string query = "delete from Personel where ID=" + key + ";";
                        SqlCommand komut = new SqlCommand(query, baglanti);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Personel Silme İşlemi Başaraılı!");
                        baglanti.Close();
                        uyeler();

                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Ex.Message");
                        throw;
                    }
                }
            }
        }

        private void PerData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(PerData.SelectedRows[0].Cells[0].Value.ToString());
            AdSoyadTB.Text = PerData.SelectedRows[0].Cells[1].Value.ToString();
            TelTB.Text = PerData.SelectedRows[0].Cells[2].Value.ToString();
            MaasTB.Text = PerData.SelectedRows[0].Cells[3].Value.ToString();
            CinsiyetCB.Text = PerData.SelectedRows[0].Cells[4].Value.ToString();




        }

        private void GuncelleBt_Click(object sender, EventArgs e)
        {
            if (key == 0 || AdSoyadTB.Text == "" || TelTB.Text == "" || MaasTB.Text == "" || CinsiyetCB.Text == "" )
            {
                MessageBox.Show("Güncellenicek Personeli Seçiniz!!");

            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update  Personel  set PerAdSoyad='" + AdSoyadTB.Text + "', PerTelNo = '" + TelTB.Text + "', PerMaas = '" + MaasTB.Text + "', PerCinsiyet = '" + CinsiyetCB.Text + "' where ID = " + key + "; ";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Personel Güncelleme Başaraılı!");
                    baglanti.Close();
                    uyeler();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                    throw;
                }
            }
        }

        private void GeriBt_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();

        }
    }
    }
