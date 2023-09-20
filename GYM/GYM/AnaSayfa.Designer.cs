
namespace GYM
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.UyeEkle = new System.Windows.Forms.Button();
            this.UyeSil = new System.Windows.Forms.Button();
            this.Odeme = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UyeGorBT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.GYMGiris = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UyeEkle
            // 
            this.UyeEkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UyeEkle.BackColor = System.Drawing.Color.Gray;
            this.UyeEkle.ForeColor = System.Drawing.Color.White;
            this.UyeEkle.Location = new System.Drawing.Point(79, 12);
            this.UyeEkle.Name = "UyeEkle";
            this.UyeEkle.Size = new System.Drawing.Size(112, 31);
            this.UyeEkle.TabIndex = 0;
            this.UyeEkle.Text = "Üye Ekle";
            this.UyeEkle.UseVisualStyleBackColor = false;
            this.UyeEkle.Click += new System.EventHandler(this.UyeEkle_Click);
            // 
            // UyeSil
            // 
            this.UyeSil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UyeSil.BackColor = System.Drawing.Color.Gray;
            this.UyeSil.ForeColor = System.Drawing.Color.White;
            this.UyeSil.Location = new System.Drawing.Point(303, 12);
            this.UyeSil.Name = "UyeSil";
            this.UyeSil.Size = new System.Drawing.Size(112, 31);
            this.UyeSil.TabIndex = 1;
            this.UyeSil.Text = "Üye Sil/Güncelle";
            this.UyeSil.UseVisualStyleBackColor = false;
            this.UyeSil.Click += new System.EventHandler(this.UyeSil_Click);
            // 
            // Odeme
            // 
            this.Odeme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Odeme.BackColor = System.Drawing.Color.Gray;
            this.Odeme.ForeColor = System.Drawing.Color.White;
            this.Odeme.Location = new System.Drawing.Point(497, 12);
            this.Odeme.Name = "Odeme";
            this.Odeme.Size = new System.Drawing.Size(112, 31);
            this.Odeme.TabIndex = 3;
            this.Odeme.Text = "Ödeme";
            this.Odeme.UseVisualStyleBackColor = false;
            this.Odeme.Click += new System.EventHandler(this.Odeme_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.UyeGorBT);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Odeme);
            this.panel1.Controls.Add(this.UyeEkle);
            this.panel1.Controls.Add(this.UyeSil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 56);
            this.panel1.TabIndex = 4;
            // 
            // UyeGorBT
            // 
            this.UyeGorBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UyeGorBT.BackColor = System.Drawing.Color.Gray;
            this.UyeGorBT.ForeColor = System.Drawing.Color.White;
            this.UyeGorBT.Location = new System.Drawing.Point(677, 12);
            this.UyeGorBT.Name = "UyeGorBT";
            this.UyeGorBT.Size = new System.Drawing.Size(112, 31);
            this.UyeGorBT.TabIndex = 6;
            this.UyeGorBT.Text = "Uye Görüntüle";
            this.UyeGorBT.UseVisualStyleBackColor = false;
            this.UyeGorBT.Click += new System.EventHandler(this.UyeGorBT_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(882, 12);
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
            this.GYMGiris.Location = new System.Drawing.Point(230, 79);
            this.GYMGiris.Margin = new System.Windows.Forms.Padding(20);
            this.GYMGiris.Name = "GYMGiris";
            this.GYMGiris.Size = new System.Drawing.Size(389, 59);
            this.GYMGiris.TabIndex = 5;
            this.GYMGiris.Text = "TK GYM";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 602);
            this.Controls.Add(this.GYMGiris);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UyeEkle;
        private System.Windows.Forms.Button UyeSil;
        private System.Windows.Forms.Button Odeme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label GYMGiris;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button UyeGorBT;
    }
}