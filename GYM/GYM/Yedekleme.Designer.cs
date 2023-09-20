
namespace GYM
{
    partial class Yedekleme
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pathtb = new System.Windows.Forms.TextBox();
            this.restorepath = new System.Windows.Forms.TextBox();
            this.pathbt = new System.Windows.Forms.Button();
            this.yedeklebt = new System.Windows.Forms.Button();
            this.path2bt = new System.Windows.Forms.Button();
            this.restorebt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veritabanı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kaydedilcek Yol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dosyanın Yeri";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(139, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "GURAYMARK-XII\\SQLEXPRESS";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(139, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(278, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "GYM";
            // 
            // pathtb
            // 
            this.pathtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pathtb.Location = new System.Drawing.Point(139, 106);
            this.pathtb.Name = "pathtb";
            this.pathtb.Size = new System.Drawing.Size(278, 26);
            this.pathtb.TabIndex = 6;
            // 
            // restorepath
            // 
            this.restorepath.Location = new System.Drawing.Point(139, 216);
            this.restorepath.Name = "restorepath";
            this.restorepath.Size = new System.Drawing.Size(278, 20);
            this.restorepath.TabIndex = 7;
            // 
            // pathbt
            // 
            this.pathbt.Location = new System.Drawing.Point(424, 106);
            this.pathbt.Name = "pathbt";
            this.pathbt.Size = new System.Drawing.Size(75, 26);
            this.pathbt.TabIndex = 8;
            this.pathbt.Text = "Gez";
            this.pathbt.UseVisualStyleBackColor = true;
            this.pathbt.Click += new System.EventHandler(this.pathbt_Click);
            // 
            // yedeklebt
            // 
            this.yedeklebt.Location = new System.Drawing.Point(229, 150);
            this.yedeklebt.Name = "yedeklebt";
            this.yedeklebt.Size = new System.Drawing.Size(75, 23);
            this.yedeklebt.TabIndex = 9;
            this.yedeklebt.Text = "Yedekle";
            this.yedeklebt.UseVisualStyleBackColor = true;
            this.yedeklebt.Click += new System.EventHandler(this.yedeklebt_Click);
            // 
            // path2bt
            // 
            this.path2bt.Location = new System.Drawing.Point(424, 216);
            this.path2bt.Name = "path2bt";
            this.path2bt.Size = new System.Drawing.Size(75, 23);
            this.path2bt.TabIndex = 10;
            this.path2bt.Text = "Gez";
            this.path2bt.UseVisualStyleBackColor = true;
            this.path2bt.Click += new System.EventHandler(this.path2bt_Click);
            // 
            // restorebt
            // 
            this.restorebt.Location = new System.Drawing.Point(229, 252);
            this.restorebt.Name = "restorebt";
            this.restorebt.Size = new System.Drawing.Size(75, 23);
            this.restorebt.TabIndex = 11;
            this.restorebt.Text = "Kurtar";
            this.restorebt.UseVisualStyleBackColor = true;
            this.restorebt.Click += new System.EventHandler(this.restorebt_Click);
            // 
            // Yedekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 315);
            this.Controls.Add(this.restorebt);
            this.Controls.Add(this.path2bt);
            this.Controls.Add(this.yedeklebt);
            this.Controls.Add(this.pathbt);
            this.Controls.Add(this.restorepath);
            this.Controls.Add(this.pathtb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Yedekleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yedekleme";
            this.Load += new System.EventHandler(this.Yedekleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox pathtb;
        private System.Windows.Forms.TextBox restorepath;
        private System.Windows.Forms.Button pathbt;
        private System.Windows.Forms.Button yedeklebt;
        private System.Windows.Forms.Button path2bt;
        private System.Windows.Forms.Button restorebt;
    }
}