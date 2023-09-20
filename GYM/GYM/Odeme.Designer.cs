
namespace GYM
{
    partial class Odeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odeme));
            this.GYMGiris = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TutarTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Periyot = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Öde = new System.Windows.Forms.Button();
            this.GeriBT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.AdSoyadCB = new System.Windows.Forms.ComboBox();
            this.OdemeData = new System.Windows.Forms.DataGridView();
            this.AraTB = new System.Windows.Forms.TextBox();
            this.AraBT = new System.Windows.Forms.Button();
            this.Yenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OdemeData)).BeginInit();
            this.SuspendLayout();
            // 
            // GYMGiris
            // 
            this.GYMGiris.AutoSize = true;
            this.GYMGiris.Font = new System.Drawing.Font("Wide Latin", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GYMGiris.Location = new System.Drawing.Point(245, 17);
            this.GYMGiris.Margin = new System.Windows.Forms.Padding(20);
            this.GYMGiris.Name = "GYMGiris";
            this.GYMGiris.Size = new System.Drawing.Size(389, 59);
            this.GYMGiris.TabIndex = 6;
            this.GYMGiris.Text = "TK GYM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ödeme";
            // 
            // TutarTB
            // 
            this.TutarTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TutarTB.Location = new System.Drawing.Point(22, 562);
            this.TutarTB.Multiline = true;
            this.TutarTB.Name = "TutarTB";
            this.TutarTB.Size = new System.Drawing.Size(223, 29);
            this.TutarTB.TabIndex = 12;
            this.TutarTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 499);
            this.label3.Margin = new System.Windows.Forms.Padding(20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 376);
            this.label2.Margin = new System.Windows.Forms.Padding(20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Üye Ad Soyad";
            // 
            // Periyot
            // 
            this.Periyot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Periyot.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Periyot.Location = new System.Drawing.Point(22, 309);
            this.Periyot.Name = "Periyot";
            this.Periyot.Size = new System.Drawing.Size(111, 29);
            this.Periyot.TabIndex = 13;
            this.Periyot.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ödenecek Ay";
            // 
            // Öde
            // 
            this.Öde.BackColor = System.Drawing.Color.White;
            this.Öde.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Öde.ForeColor = System.Drawing.Color.Black;
            this.Öde.Location = new System.Drawing.Point(312, 580);
            this.Öde.Name = "Öde";
            this.Öde.Size = new System.Drawing.Size(215, 52);
            this.Öde.TabIndex = 28;
            this.Öde.TabStop = false;
            this.Öde.Text = "Öde";
            this.Öde.UseVisualStyleBackColor = false;
            this.Öde.Click += new System.EventHandler(this.Login_Click);
            // 
            // GeriBT
            // 
            this.GeriBT.BackColor = System.Drawing.Color.White;
            this.GeriBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GeriBT.ForeColor = System.Drawing.Color.Black;
            this.GeriBT.Location = new System.Drawing.Point(609, 580);
            this.GeriBT.Name = "GeriBT";
            this.GeriBT.Size = new System.Drawing.Size(215, 52);
            this.GeriBT.TabIndex = 29;
            this.GeriBT.TabStop = false;
            this.GeriBT.Text = "Geri";
            this.GeriBT.UseVisualStyleBackColor = false;
            this.GeriBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(873, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // AdSoyadCB
            // 
            this.AdSoyadCB.FormattingEnabled = true;
            this.AdSoyadCB.Location = new System.Drawing.Point(22, 437);
            this.AdSoyadCB.Name = "AdSoyadCB";
            this.AdSoyadCB.Size = new System.Drawing.Size(138, 21);
            this.AdSoyadCB.TabIndex = 35;
            this.AdSoyadCB.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // OdemeData
            // 
            this.OdemeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OdemeData.Location = new System.Drawing.Point(272, 250);
            this.OdemeData.Name = "OdemeData";
            this.OdemeData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OdemeData.Size = new System.Drawing.Size(590, 317);
            this.OdemeData.TabIndex = 48;
            this.OdemeData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OdemeData_CellContentClick);
            // 
            // AraTB
            // 
            this.AraTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AraTB.Location = new System.Drawing.Point(312, 215);
            this.AraTB.Multiline = true;
            this.AraTB.Name = "AraTB";
            this.AraTB.Size = new System.Drawing.Size(223, 29);
            this.AraTB.TabIndex = 49;
            // 
            // AraBT
            // 
            this.AraBT.BackColor = System.Drawing.Color.White;
            this.AraBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AraBT.ForeColor = System.Drawing.Color.Black;
            this.AraBT.Location = new System.Drawing.Point(541, 215);
            this.AraBT.Name = "AraBT";
            this.AraBT.Size = new System.Drawing.Size(141, 34);
            this.AraBT.TabIndex = 50;
            this.AraBT.TabStop = false;
            this.AraBT.Text = "Ara";
            this.AraBT.UseVisualStyleBackColor = false;
            this.AraBT.Click += new System.EventHandler(this.AraBT_Click);
            // 
            // Yenile
            // 
            this.Yenile.BackColor = System.Drawing.Color.White;
            this.Yenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yenile.ForeColor = System.Drawing.Color.Black;
            this.Yenile.Location = new System.Drawing.Point(683, 215);
            this.Yenile.Name = "Yenile";
            this.Yenile.Size = new System.Drawing.Size(141, 34);
            this.Yenile.TabIndex = 51;
            this.Yenile.TabStop = false;
            this.Yenile.Text = "Yenile";
            this.Yenile.UseVisualStyleBackColor = false;
            this.Yenile.Click += new System.EventHandler(this.Yenile_Click);
            // 
            // Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 647);
            this.Controls.Add(this.Yenile);
            this.Controls.Add(this.AraBT);
            this.Controls.Add(this.AraTB);
            this.Controls.Add(this.OdemeData);
            this.Controls.Add(this.AdSoyadCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GeriBT);
            this.Controls.Add(this.Öde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Periyot);
            this.Controls.Add(this.TutarTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GYMGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Odeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odeme";
            this.Load += new System.EventHandler(this.Odeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OdemeData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GYMGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TutarTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Periyot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Öde;
        private System.Windows.Forms.Button GeriBT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AdSoyadCB;
        private System.Windows.Forms.DataGridView OdemeData;
        private System.Windows.Forms.TextBox AraTB;
        private System.Windows.Forms.Button AraBT;
        private System.Windows.Forms.Button Yenile;
    }
}