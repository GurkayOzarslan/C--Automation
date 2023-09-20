
namespace GYM
{
    partial class GirisEkran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkran));
            this.GYMAd = new System.Windows.Forms.Label();
            this.GirisTB = new System.Windows.Forms.TextBox();
            this.SifreTB = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.PictureBox();
            this.Lock = new System.Windows.Forms.PictureBox();
            this.Login = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lock)).BeginInit();
            this.SuspendLayout();
            // 
            // GYMAd
            // 
            this.GYMAd.AutoSize = true;
            this.GYMAd.Font = new System.Drawing.Font("Wide Latin", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GYMAd.Location = new System.Drawing.Point(186, 29);
            this.GYMAd.Margin = new System.Windows.Forms.Padding(20);
            this.GYMAd.Name = "GYMAd";
            this.GYMAd.Size = new System.Drawing.Size(389, 59);
            this.GYMAd.TabIndex = 0;
            this.GYMAd.Text = "TK GYM";
            this.GYMAd.Click += new System.EventHandler(this.GYMAd_Click);
            // 
            // GirisTB
            // 
            this.GirisTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisTB.ForeColor = System.Drawing.Color.Black;
            this.GirisTB.Location = new System.Drawing.Point(196, 188);
            this.GirisTB.Multiline = true;
            this.GirisTB.Name = "GirisTB";
            this.GirisTB.Size = new System.Drawing.Size(291, 32);
            this.GirisTB.TabIndex = 1;
            this.GirisTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SifreTB
            // 
            this.SifreTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreTB.ForeColor = System.Drawing.Color.Black;
            this.SifreTB.Location = new System.Drawing.Point(196, 259);
            this.SifreTB.Multiline = true;
            this.SifreTB.Name = "SifreTB";
            this.SifreTB.PasswordChar = '*';
            this.SifreTB.Size = new System.Drawing.Size(291, 32);
            this.SifreTB.TabIndex = 2;
            this.SifreTB.TextChanged += new System.EventHandler(this.SifreTB_TextChanged);
            // 
            // User
            // 
            this.User.ImageLocation = "zoom";
            this.User.InitialImage = ((System.Drawing.Image)(resources.GetObject("User.InitialImage")));
            this.User.Location = new System.Drawing.Point(493, 188);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(41, 32);
            this.User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.User.TabIndex = 3;
            this.User.TabStop = false;
            this.User.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Lock
            // 
            this.Lock.Image = ((System.Drawing.Image)(resources.GetObject("Lock.Image")));
            this.Lock.Location = new System.Drawing.Point(493, 259);
            this.Lock.Name = "Lock";
            this.Lock.Size = new System.Drawing.Size(41, 32);
            this.Lock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Lock.TabIndex = 4;
            this.Lock.TabStop = false;
            this.Lock.Click += new System.EventHandler(this.Lock_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.White;
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Login.ForeColor = System.Drawing.Color.Black;
            this.Login.Location = new System.Drawing.Point(211, 344);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(93, 45);
            this.Login.TabIndex = 5;
            this.Login.TabStop = false;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.White;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Reset.ForeColor = System.Drawing.Color.Black;
            this.Reset.Location = new System.Drawing.Point(360, 344);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(93, 45);
            this.Reset.TabIndex = 6;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // GirisEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(799, 530);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Lock);
            this.Controls.Add(this.User);
            this.Controls.Add(this.SifreTB);
            this.Controls.Add(this.GirisTB);
            this.Controls.Add(this.GYMAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GirisEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GYMAd;
        private System.Windows.Forms.TextBox GirisTB;
        private System.Windows.Forms.TextBox SifreTB;
        private System.Windows.Forms.PictureBox User;
        private System.Windows.Forms.PictureBox Lock;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Reset;
    }
}

