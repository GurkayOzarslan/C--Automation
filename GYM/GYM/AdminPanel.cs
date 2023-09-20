using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void cik_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void PersonelEkle_Click(object sender, EventArgs e)
        {
            PersonelEkle pe = new PersonelEkle();
            pe.Show();
            this.Hide();
        }

        private void PerSil_Click(object sender, EventArgs e)
        {
            PersonelSil ps = new PersonelSil();
            ps.Show();
            this.Hide();

        }

        private void PerBilg_Click(object sender, EventArgs e)
        {
            PersonelBilgi pg = new PersonelBilgi();
            pg.Show();
            this.Hide();

        }

        private void AnasayfaBT_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();

        }

        private void PersonelGorBT_Click(object sender, EventArgs e)
        {
            PersonelGor pg = new PersonelGor();
            pg.Show();
            this.Hide();
        }

        private void YedekleBT_Click(object sender, EventArgs e)
        {
            Yedekleme yedek = new Yedekleme();
            yedek.Show();
            this.Hide();
        }
    }
}
