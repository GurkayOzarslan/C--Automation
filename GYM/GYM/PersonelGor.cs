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
    public partial class PersonelGor : Form
    {
        public PersonelGor()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=GURAYMARK-XII\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        private void personel()
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


        private void PersonelGor_Load(object sender, EventArgs e)
        {
            personel();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //Application.Exit();

        }
        private void AdFiltrele()
        {
            baglanti.Open();
            string query = "select*from Personel where PerAdSoyad like '%" + AraPerTB.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dataset = new DataSet();
            sda.Fill(dataset);
            PerData.DataSource = dataset.Tables[0];
            baglanti.Close();

        }
        private void NoFiltre()
        {
            baglanti.Open();
            string query = "select*from Personel where PerTelNo like '%" + TelNoTB.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dataset = new DataSet();
            sda.Fill(dataset);
            PerData.DataSource = dataset.Tables[0];
            baglanti.Close();

        }
        private void MaasFiltrele()
        {
            baglanti.Open();
            string query = "select*from Personel where PerMaas like '%" + MaasTB.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dataset = new DataSet();
            sda.Fill(dataset);
            PerData.DataSource = dataset.Tables[0];
            baglanti.Close();

        }
        private void CinsiyetFiltrele()
        {
            baglanti.Open();
            string query = "select*from Personel where PerCinsiyet like '%" + CinsiyetCB.ToString() + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dataset = new DataSet();
            sda.Fill(dataset);
            PerData.DataSource = dataset.Tables[0];
            baglanti.Close();

        }
        private void AraBT_Click(object sender, EventArgs e)
        {
            AdFiltrele();
            AraPerTB.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();
        }

        private void YenileBT_Click(object sender, EventArgs e)
        {
            personel();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NoFiltre();
            TelNoTB.Text = "";
        }

        private void AraPerTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            personel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            personel();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            personel();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MaasFiltrele();
            MaasTB.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CinsiyetFiltrele();
            CinsiyetCB.Text = "";
        }

        private void Cikti_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application().Application.Application.Application.Application.Application.Application.Application.Application;
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];
            int baslamakolonu = 1;
            int baslamasatiri = 1;
            for (int j = 0; j < PerData.Columns.Count; j++)
            {
                Range range = (Range)worksheet.Cells[baslamasatiri, baslamakolonu + j];
                range.Value2 = PerData.Columns[j].HeaderText;

            }
            baslamasatiri++;
            for (int i = 0; i < PerData.Rows.Count; i++)
            {
                for (int j = 0; j < PerData.Columns.Count; j++)
                {
                    Range range = (Range)worksheet.Cells[baslamasatiri + i, baslamasatiri + j];
                    range.Value2 = PerData[j, i].Value == null ? "" : PerData[j, i].Value;
                    range.Select();
                }
            }
        }
    }
}
