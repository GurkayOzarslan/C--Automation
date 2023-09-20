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
    public partial class Yedekleme : Form
    {
        public Yedekleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=GURAYMARK-XII\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");

        private void Yedekleme_Load(object sender, EventArgs e)
        {

        }

        private void pathbt_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pathtb.Text = dlg.SelectedPath;
                yedeklebt.Enabled = true;

            }
        }

        private void yedeklebt_Click(object sender, EventArgs e)
        {
            string database = baglanti.Database.ToString();
            if (pathtb.Text==string.Empty)
            {
                MessageBox.Show("Dosyanın Kaydedilcek Yerini Seçin");

            }
            else
            {
                string cmd = "BACKUP DATABASE [" + database + "]TO DISK= '" + pathtb.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss")+".bak'";
                baglanti.Open();
                SqlCommand command = new SqlCommand(cmd,baglanti);
                command.ExecuteNonQuery();
                MessageBox.Show("Veritabanı Yedekleme Başarılı");
                baglanti.Close();
                yedeklebt.Enabled = false;

            }
        }

        private void path2bt_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER veritabanı yedek dosyası|*.bak";
            dlg.Title = "Database kurtar";
            if (dlg.ShowDialog()==DialogResult.OK)

            {
                restorepath.Text = dlg.FileName;
                restorebt.Enabled = true;

            }
        }

        private void restorebt_Click(object sender, EventArgs e)
        {
            string database = baglanti.Database.ToString();
            baglanti.Open();
            try
            {
                string str1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(str1, baglanti);
                cmd1.ExecuteNonQuery();
                string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + restorepath.Text + "'WITH REPLACE;";
                SqlCommand cmd2 = new SqlCommand(str2, baglanti);
                cmd2.ExecuteNonQuery();
                string str3 = string.Format("ALTER DATABASE [" + database + "]SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(str3, baglanti);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Kurtarma İşlemi Başarılı", "Bilgi");
                baglanti.Close();


            }
            catch (Exception)
            {

                MessageBox.Show("ex.Message","Hata");
            }
        }
    }
}
