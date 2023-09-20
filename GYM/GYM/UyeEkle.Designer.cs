
using System;

namespace GYM
{
    partial class UyeEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeEkle));
            this.Baslik = new System.Windows.Forms.Label();
            this.UyeAdSoyadLB = new System.Windows.Forms.Label();
            this.UyeAdSoyadTB = new System.Windows.Forms.TextBox();
            this.UyeTELNLB = new System.Windows.Forms.Label();
            this.UyeTelefonTB = new System.Windows.Forms.TextBox();
            this.UyeYasTB = new System.Windows.Forms.TextBox();
            this.UyeYas = new System.Windows.Forms.Label();
            this.UyeCinsiyet = new System.Windows.Forms.Label();
            this.UyeOdeme = new System.Windows.Forms.Label();
            this.CinsiyetCB = new System.Windows.Forms.ComboBox();
            this.UyeOdemeTB = new System.Windows.Forms.TextBox();
            this.EkleBt = new System.Windows.Forms.Button();
            this.GeriBT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.GYMGiris = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Baslik
            // 
            this.Baslik.AutoSize = true;
            this.Baslik.BackColor = System.Drawing.Color.Black;
            this.Baslik.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Baslik.ForeColor = System.Drawing.Color.White;
            this.Baslik.Location = new System.Drawing.Point(261, 117);
            this.Baslik.Margin = new System.Windows.Forms.Padding(20);
            this.Baslik.Name = "Baslik";
            this.Baslik.Size = new System.Drawing.Size(240, 32);
            this.Baslik.TabIndex = 2;
            this.Baslik.Text = "Yeni Üye Ekleme";
            this.Baslik.Click += new System.EventHandler(this.label1_Click);
            // 
            // UyeAdSoyadLB
            // 
            this.UyeAdSoyadLB.AutoSize = true;
            this.UyeAdSoyadLB.BackColor = System.Drawing.Color.White;
            this.UyeAdSoyadLB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeAdSoyadLB.ForeColor = System.Drawing.Color.Black;
            this.UyeAdSoyadLB.Location = new System.Drawing.Point(9, 162);
            this.UyeAdSoyadLB.Margin = new System.Windows.Forms.Padding(20);
            this.UyeAdSoyadLB.Name = "UyeAdSoyadLB";
            this.UyeAdSoyadLB.Size = new System.Drawing.Size(154, 24);
            this.UyeAdSoyadLB.TabIndex = 3;
            this.UyeAdSoyadLB.Text = "Üye Ad Soyad";
            this.UyeAdSoyadLB.Click += new System.EventHandler(this.label2_Click);
            // 
            // UyeAdSoyadTB
            // 
            this.UyeAdSoyadTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeAdSoyadTB.Location = new System.Drawing.Point(13, 217);
            this.UyeAdSoyadTB.Multiline = true;
            this.UyeAdSoyadTB.Name = "UyeAdSoyadTB";
            this.UyeAdSoyadTB.Size = new System.Drawing.Size(223, 29);
            this.UyeAdSoyadTB.TabIndex = 4;
            // 
            // UyeTELNLB
            // 
            this.UyeTELNLB.AutoSize = true;
            this.UyeTELNLB.BackColor = System.Drawing.Color.White;
            this.UyeTELNLB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeTELNLB.ForeColor = System.Drawing.Color.Black;
            this.UyeTELNLB.Location = new System.Drawing.Point(304, 162);
            this.UyeTELNLB.Margin = new System.Windows.Forms.Padding(20);
            this.UyeTELNLB.Name = "UyeTELNLB";
            this.UyeTELNLB.Size = new System.Drawing.Size(130, 24);
            this.UyeTELNLB.TabIndex = 5;
            this.UyeTELNLB.Text = "Üye Tel No";
            // 
            // UyeTelefonTB
            // 
            this.UyeTelefonTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeTelefonTB.Location = new System.Drawing.Point(310, 217);
            this.UyeTelefonTB.Multiline = true;
            this.UyeTelefonTB.Name = "UyeTelefonTB";
            this.UyeTelefonTB.Size = new System.Drawing.Size(223, 29);
            this.UyeTelefonTB.TabIndex = 6;
            this.UyeTelefonTB.TextChanged += new System.EventHandler(this.UyeTelefonTB_TextChanged);
            // 
            // UyeYasTB
            // 
            this.UyeYasTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeYasTB.Location = new System.Drawing.Point(596, 217);
            this.UyeYasTB.Multiline = true;
            this.UyeYasTB.Name = "UyeYasTB";
            this.UyeYasTB.Size = new System.Drawing.Size(223, 29);
            this.UyeYasTB.TabIndex = 7;
            // 
            // UyeYas
            // 
            this.UyeYas.AutoSize = true;
            this.UyeYas.BackColor = System.Drawing.Color.White;
            this.UyeYas.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeYas.ForeColor = System.Drawing.Color.Black;
            this.UyeYas.Location = new System.Drawing.Point(590, 162);
            this.UyeYas.Margin = new System.Windows.Forms.Padding(20);
            this.UyeYas.Name = "UyeYas";
            this.UyeYas.Size = new System.Drawing.Size(94, 24);
            this.UyeYas.TabIndex = 8;
            this.UyeYas.Text = "Üye Yas";
            // 
            // UyeCinsiyet
            // 
            this.UyeCinsiyet.AutoSize = true;
            this.UyeCinsiyet.BackColor = System.Drawing.Color.White;
            this.UyeCinsiyet.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeCinsiyet.ForeColor = System.Drawing.Color.Black;
            this.UyeCinsiyet.Location = new System.Drawing.Point(9, 311);
            this.UyeCinsiyet.Margin = new System.Windows.Forms.Padding(20);
            this.UyeCinsiyet.Name = "UyeCinsiyet";
            this.UyeCinsiyet.Size = new System.Drawing.Size(106, 24);
            this.UyeCinsiyet.TabIndex = 9;
            this.UyeCinsiyet.Text = "Cinsiyet";
            this.UyeCinsiyet.Click += new System.EventHandler(this.label5_Click);
            // 
            // UyeOdeme
            // 
            this.UyeOdeme.AutoSize = true;
            this.UyeOdeme.BackColor = System.Drawing.Color.White;
            this.UyeOdeme.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeOdeme.ForeColor = System.Drawing.Color.Black;
            this.UyeOdeme.Location = new System.Drawing.Point(304, 311);
            this.UyeOdeme.Margin = new System.Windows.Forms.Padding(20);
            this.UyeOdeme.Name = "UyeOdeme";
            this.UyeOdeme.Size = new System.Drawing.Size(142, 24);
            this.UyeOdeme.TabIndex = 10;
            this.UyeOdeme.Text = "Aylık Tutar";
            // 
            // CinsiyetCB
            // 
            this.CinsiyetCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CinsiyetCB.FormattingEnabled = true;
            this.CinsiyetCB.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CinsiyetCB.Location = new System.Drawing.Point(13, 379);
            this.CinsiyetCB.Name = "CinsiyetCB";
            this.CinsiyetCB.Size = new System.Drawing.Size(121, 32);
            this.CinsiyetCB.TabIndex = 11;
            this.CinsiyetCB.SelectedIndexChanged += new System.EventHandler(this.CinsiyetCB_SelectedIndexChanged);
            // 
            // UyeOdemeTB
            // 
            this.UyeOdemeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeOdemeTB.Location = new System.Drawing.Point(308, 382);
            this.UyeOdemeTB.Multiline = true;
            this.UyeOdemeTB.Name = "UyeOdemeTB";
            this.UyeOdemeTB.Size = new System.Drawing.Size(223, 29);
            this.UyeOdemeTB.TabIndex = 12;
            // 
            // EkleBt
            // 
            this.EkleBt.BackColor = System.Drawing.Color.White;
            this.EkleBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkleBt.ForeColor = System.Drawing.Color.Black;
            this.EkleBt.Location = new System.Drawing.Point(296, 457);
            this.EkleBt.Name = "EkleBt";
            this.EkleBt.Size = new System.Drawing.Size(93, 45);
            this.EkleBt.TabIndex = 13;
            this.EkleBt.TabStop = false;
            this.EkleBt.Text = "Ekle";
            this.EkleBt.UseVisualStyleBackColor = false;
            this.EkleBt.Click += new System.EventHandler(this.Login_Click);
            // 
            // GeriBT
            // 
            this.GeriBT.BackColor = System.Drawing.Color.White;
            this.GeriBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GeriBT.ForeColor = System.Drawing.Color.Black;
            this.GeriBT.Location = new System.Drawing.Point(395, 457);
            this.GeriBT.Name = "GeriBT";
            this.GeriBT.Size = new System.Drawing.Size(93, 45);
            this.GeriBT.TabIndex = 14;
            this.GeriBT.TabStop = false;
            this.GeriBT.Text = "Geri";
            this.GeriBT.UseVisualStyleBackColor = false;
            this.GeriBT.Click += new System.EventHandler(this.GeriBT_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(849, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // GYMGiris
            // 
            this.GYMGiris.AutoSize = true;
            this.GYMGiris.Font = new System.Drawing.Font("Wide Latin", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GYMGiris.Location = new System.Drawing.Point(233, 9);
            this.GYMGiris.Margin = new System.Windows.Forms.Padding(20);
            this.GYMGiris.Name = "GYMGiris";
            this.GYMGiris.Size = new System.Drawing.Size(389, 59);
            this.GYMGiris.TabIndex = 33;
            this.GYMGiris.Text = "TK GYM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(590, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Üye Yas";
            // 
            // UyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(877, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GYMGiris);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GeriBT);
            this.Controls.Add(this.EkleBt);
            this.Controls.Add(this.UyeOdemeTB);
            this.Controls.Add(this.CinsiyetCB);
            this.Controls.Add(this.UyeOdeme);
            this.Controls.Add(this.UyeCinsiyet);
            this.Controls.Add(this.UyeYas);
            this.Controls.Add(this.UyeYasTB);
            this.Controls.Add(this.UyeTelefonTB);
            this.Controls.Add(this.UyeTELNLB);
            this.Controls.Add(this.UyeAdSoyadTB);
            this.Controls.Add(this.UyeAdSoyadLB);
            this.Controls.Add(this.Baslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UyeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeEkle";
            this.Load += new System.EventHandler(this.UyeEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void GeriBT_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void UyeTelefonTB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label Baslik;
        private System.Windows.Forms.Label UyeAdSoyadLB;
        private System.Windows.Forms.TextBox UyeAdSoyadTB;
        private System.Windows.Forms.Label UyeTELNLB;
        private System.Windows.Forms.TextBox UyeTelefonTB;
        private System.Windows.Forms.TextBox UyeYasTB;
        private System.Windows.Forms.Label UyeYas;
        private System.Windows.Forms.Label UyeCinsiyet;
        private System.Windows.Forms.Label UyeOdeme;
        private System.Windows.Forms.ComboBox CinsiyetCB;
        private System.Windows.Forms.TextBox UyeOdemeTB;
        private System.Windows.Forms.Button EkleBt;
        private System.Windows.Forms.Button GeriBT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label GYMGiris;
        private System.Windows.Forms.Label label1;
    }
}