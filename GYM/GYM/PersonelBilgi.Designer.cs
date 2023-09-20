
namespace GYM
{
    partial class PersonelBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelBilgi));
            this.Yenile = new System.Windows.Forms.Button();
            this.AraBT = new System.Windows.Forms.Button();
            this.AraTB = new System.Windows.Forms.TextBox();
            this.OdemeData = new System.Windows.Forms.DataGridView();
            this.AdSoyadCB = new System.Windows.Forms.ComboBox();
            this.GeriBT = new System.Windows.Forms.Button();
            this.KaydetBT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SifreTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PerLB = new System.Windows.Forms.Label();
            this.GYMGiris = new System.Windows.Forms.Label();
            this.KullanıcıTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OdemeData)).BeginInit();
            this.SuspendLayout();
            // 
            // Yenile
            // 
            this.Yenile.BackColor = System.Drawing.Color.White;
            this.Yenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yenile.ForeColor = System.Drawing.Color.Black;
            this.Yenile.Location = new System.Drawing.Point(689, 144);
            this.Yenile.Name = "Yenile";
            this.Yenile.Size = new System.Drawing.Size(141, 34);
            this.Yenile.TabIndex = 63;
            this.Yenile.TabStop = false;
            this.Yenile.Text = "Yenile";
            this.Yenile.UseVisualStyleBackColor = false;
            this.Yenile.Click += new System.EventHandler(this.Yenile_Click);
            // 
            // AraBT
            // 
            this.AraBT.BackColor = System.Drawing.Color.White;
            this.AraBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AraBT.ForeColor = System.Drawing.Color.Black;
            this.AraBT.Location = new System.Drawing.Point(547, 144);
            this.AraBT.Name = "AraBT";
            this.AraBT.Size = new System.Drawing.Size(141, 34);
            this.AraBT.TabIndex = 62;
            this.AraBT.TabStop = false;
            this.AraBT.Text = "Ara";
            this.AraBT.UseVisualStyleBackColor = false;
            this.AraBT.Click += new System.EventHandler(this.AraBT_Click);
            // 
            // AraTB
            // 
            this.AraTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AraTB.Location = new System.Drawing.Point(318, 144);
            this.AraTB.Multiline = true;
            this.AraTB.Name = "AraTB";
            this.AraTB.Size = new System.Drawing.Size(223, 29);
            this.AraTB.TabIndex = 61;
            // 
            // OdemeData
            // 
            this.OdemeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OdemeData.Location = new System.Drawing.Point(278, 179);
            this.OdemeData.Name = "OdemeData";
            this.OdemeData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OdemeData.Size = new System.Drawing.Size(590, 317);
            this.OdemeData.TabIndex = 60;
            // 
            // AdSoyadCB
            // 
            this.AdSoyadCB.FormattingEnabled = true;
            this.AdSoyadCB.Location = new System.Drawing.Point(28, 266);
            this.AdSoyadCB.Name = "AdSoyadCB";
            this.AdSoyadCB.Size = new System.Drawing.Size(138, 21);
            this.AdSoyadCB.TabIndex = 59;
            this.AdSoyadCB.SelectedIndexChanged += new System.EventHandler(this.AdSoyadCB_SelectedIndexChanged);
            // 
            // GeriBT
            // 
            this.GeriBT.BackColor = System.Drawing.Color.White;
            this.GeriBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GeriBT.ForeColor = System.Drawing.Color.Black;
            this.GeriBT.Location = new System.Drawing.Point(615, 509);
            this.GeriBT.Name = "GeriBT";
            this.GeriBT.Size = new System.Drawing.Size(215, 52);
            this.GeriBT.TabIndex = 58;
            this.GeriBT.TabStop = false;
            this.GeriBT.Text = "Geri";
            this.GeriBT.UseVisualStyleBackColor = false;
            this.GeriBT.Click += new System.EventHandler(this.GeriBT_Click);
            // 
            // KaydetBT
            // 
            this.KaydetBT.BackColor = System.Drawing.Color.White;
            this.KaydetBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KaydetBT.ForeColor = System.Drawing.Color.Black;
            this.KaydetBT.Location = new System.Drawing.Point(318, 509);
            this.KaydetBT.Name = "KaydetBT";
            this.KaydetBT.Size = new System.Drawing.Size(215, 52);
            this.KaydetBT.TabIndex = 57;
            this.KaydetBT.TabStop = false;
            this.KaydetBT.Text = "Kaydet";
            this.KaydetBT.UseVisualStyleBackColor = false;
            this.KaydetBT.Click += new System.EventHandler(this.KaydetBT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 317);
            this.label4.Margin = new System.Windows.Forms.Padding(20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // SifreTB
            // 
            this.SifreTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreTB.Location = new System.Drawing.Point(28, 491);
            this.SifreTB.Multiline = true;
            this.SifreTB.Name = "SifreTB";
            this.SifreTB.Size = new System.Drawing.Size(223, 29);
            this.SifreTB.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 428);
            this.label3.Margin = new System.Windows.Forms.Padding(20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Personel Ad Soyad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(874, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 16);
            this.label7.TabIndex = 66;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // PerLB
            // 
            this.PerLB.AutoSize = true;
            this.PerLB.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerLB.Location = new System.Drawing.Point(312, 86);
            this.PerLB.Margin = new System.Windows.Forms.Padding(20);
            this.PerLB.Name = "PerLB";
            this.PerLB.Size = new System.Drawing.Size(283, 35);
            this.PerLB.TabIndex = 65;
            this.PerLB.Text = "Personel Bilgi Sistemi";
            // 
            // GYMGiris
            // 
            this.GYMGiris.AutoSize = true;
            this.GYMGiris.Font = new System.Drawing.Font("Wide Latin", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GYMGiris.Location = new System.Drawing.Point(246, 13);
            this.GYMGiris.Margin = new System.Windows.Forms.Padding(20);
            this.GYMGiris.Name = "GYMGiris";
            this.GYMGiris.Size = new System.Drawing.Size(389, 59);
            this.GYMGiris.TabIndex = 64;
            this.GYMGiris.Text = "TK GYM";
            // 
            // KullanıcıTB
            // 
            this.KullanıcıTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullanıcıTB.Location = new System.Drawing.Point(33, 364);
            this.KullanıcıTB.Multiline = true;
            this.KullanıcıTB.Name = "KullanıcıTB";
            this.KullanıcıTB.Size = new System.Drawing.Size(223, 29);
            this.KullanıcıTB.TabIndex = 67;
            // 
            // PersonelBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 622);
            this.Controls.Add(this.KullanıcıTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PerLB);
            this.Controls.Add(this.GYMGiris);
            this.Controls.Add(this.Yenile);
            this.Controls.Add(this.AraBT);
            this.Controls.Add(this.AraTB);
            this.Controls.Add(this.OdemeData);
            this.Controls.Add(this.AdSoyadCB);
            this.Controls.Add(this.GeriBT);
            this.Controls.Add(this.KaydetBT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SifreTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelBilgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelBilgi";
            this.Load += new System.EventHandler(this.PersonelBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OdemeData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Yenile;
        private System.Windows.Forms.Button AraBT;
        private System.Windows.Forms.TextBox AraTB;
        private System.Windows.Forms.DataGridView OdemeData;
        private System.Windows.Forms.ComboBox AdSoyadCB;
        private System.Windows.Forms.Button GeriBT;
        private System.Windows.Forms.Button KaydetBT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SifreTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label PerLB;
        private System.Windows.Forms.Label GYMGiris;
        private System.Windows.Forms.TextBox KullanıcıTB;
    }
}