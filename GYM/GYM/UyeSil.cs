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
    public partial class UyeSil : Form
    {
        public UyeSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=GURAYMARK-XII\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        private void uyeler()
        {
            baglanti.Open();
            string query = "select*from Uyeler";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dataset = new DataSet();
            sda.Fill(dataset);
            UyeData.DataSource = dataset.Tables[0];
            baglanti.Close();

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek Üyeyi Seçiniz!!");

            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from Uyeler where ID=" + key + ";";
                    SqlCommand komut = new SqlCommand(query,baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Uye Silme İşlemi Başarılı!");
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

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (key == 0||AdSoyadTB.Text==""||TelTB.Text==""||YasTB.Text==""||CinsiyetCB.Text==""||OdemeTB.Text=="")
            {
                MessageBox.Show("Güncellenicek Üyeyi Seçiniz!!");

            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update  Uyeler set UyeAdSoyad='" + AdSoyadTB.Text + "',TelNo='" + TelTB.Text + "',UyeCinsiyet='" + CinsiyetCB.SelectedItem.ToString() + "',UyeOdeme='" + OdemeTB.Text + "' where ID=" + key +"; ";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Uye Güncelleme Başaraılı!");
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

        private void UyeSil_Load(object sender, EventArgs e)
        {
            uyeler();
        }
        int key = 0;
        private void UyeData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(UyeData.SelectedRows[0].Cells[0].Value.ToString());
            AdSoyadTB.Text = UyeData.SelectedRows[0].Cells[1].Value.ToString();
            TelTB.Text = UyeData.SelectedRows[0].Cells[2].Value.ToString();
            YasTB.Text = UyeData.SelectedRows[0].Cells[3].Value.ToString();
            CinsiyetCB.Text = UyeData.SelectedRows[0].Cells[4].Value.ToString();
            OdemeTB.Text = UyeData.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
