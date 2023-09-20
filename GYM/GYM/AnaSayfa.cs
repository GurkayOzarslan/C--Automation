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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void UyeEkle_Click(object sender, EventArgs e)
        {
            UyeEkle uyeekle = new UyeEkle();
            uyeekle.Show();
            this.Hide();
        }

        private void UyeSil_Click(object sender, EventArgs e)
        {
            UyeSil sil = new UyeSil();
            sil.Show();
            this.Hide();

        }

        private void Odeme_Click(object sender, EventArgs e)
        {
            Odeme odeme = new Odeme();
            odeme.Show();
            this.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void UyeGorBT_Click(object sender, EventArgs e)
        {
            UyeGoruntule UyeGor = new UyeGoruntule();
            UyeGor.Show();
            this.Hide();


        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        
    }
    }

