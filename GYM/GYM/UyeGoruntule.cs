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
using Microsoft.Office.Interop.Excel;

namespace GYM
{
    public partial class UyeGoruntule : Form
    {
        public UyeGoruntule()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=GURAYMARK-XII\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        private void uyeler()
        {
            baglanti.Open();
            string query = "select*from Uyeler";
            SqlDataAdapter sda = new SqlDataAdapter(query,baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dataset = new DataSet();
            sda.Fill(dataset);
            UyeData.DataSource = dataset.Tables[0];
            baglanti.Close();

        }
        private void label7_Click(object sender, EventArgs e)
        {
           // Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GYMGiris_Click(object sender, EventArgs e)
        {

        }
        private void AdFiltrele()
        {
            baglanti.Open();
            string query = "select*from Uyeler where UyeAdSoyad like'%" + AraUyeTB.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dataset = new DataSet();
            sda.Fill(dataset);
            UyeData.DataSource = dataset.Tables[0];
            baglanti.Close();

        }
        private void TelFiltrele()
        {
            baglanti.Open();
            string query = "select*from Uyeler where TelNo like'%" + TelNoTB.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dataset = new DataSet();
            sda.Fill(dataset);
            UyeData.DataSource = dataset.Tables[0];
            baglanti.Close();

        }
        private void YasFiltrele()
        {
            baglanti.Open();
            string query = "select*from Uyeler where UyeYas like'%" + AraYasTB.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dataset = new DataSet();
            sda.Fill(dataset);
            UyeData.DataSource = dataset.Tables[0];
            baglanti.Close();

        }
        private void OdeFiltrele()
        {
            baglanti.Open();
            string query = "select*from Uyeler where UyeOdeme like'%" + AraÖdeTB.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dataset = new DataSet();
            sda.Fill(dataset);
            UyeData.DataSource = dataset.Tables[0];
            baglanti.Close();

        }
        private void Login_Click(object sender, EventArgs e)
        {
            AdFiltrele();
            AraUyeTB.Text = "";



        }

        private void UyeGoruntule_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();

        }

        private void UyeData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void YenileBT_Click(object sender, EventArgs e)
        {
            uyeler();

        }

        private void AraBT_Click(object sender, EventArgs e)
        {
            AdFiltrele();
            AraUyeTB.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelFiltrele();
            TelNoTB.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            YasFiltrele();
            AraYasTB.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OdeFiltrele();
            AraÖdeTB.Text = "";
        }

        private void ExcelBT_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application().Application.Application.Application.Application.Application.Application.Application.Application;
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];
            int baslamakolonu = 1;
            int baslamasatiri = 1;
            for (int j = 0; j < UyeData.Columns.Count; j++)
            {
                Range range = (Range)worksheet.Cells[baslamasatiri, baslamakolonu +j];
                range.Value2 = UyeData.Columns[j].HeaderText;

            }
            baslamasatiri++;
            for (int i = 0; i < UyeData.Rows.Count; i++)
            {
                for (int j = 0; j < UyeData.Columns.Count; j++)
                {
                    Range range = (Range)worksheet.Cells[baslamasatiri + i, baslamasatiri + j];
                    range.Value2 = UyeData[j, i].Value == null ? "": UyeData[j, i].Value;
                    range.Select();
                }
            }
            
            
        }
    }
}
