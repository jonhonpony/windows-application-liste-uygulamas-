namespace BuyukOrnek
{
    partial class Anaform
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grp_islemler = new System.Windows.Forms.GroupBox();
            this.btn_yenikayit = new System.Windows.Forms.Button();
            this.btn_liste = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_zaman = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.grp_islemler.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.grp_islemler);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 1;
            // 
            // grp_islemler
            // 
            this.grp_islemler.Controls.Add(this.btn_kapat);
            this.grp_islemler.Controls.Add(this.btn_liste);
            this.grp_islemler.Controls.Add(this.btn_yenikayit);
            this.grp_islemler.Enabled = false;
            this.grp_islemler.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grp_islemler.ForeColor = System.Drawing.Color.Brown;
            this.grp_islemler.Location = new System.Drawing.Point(25, 211);
            this.grp_islemler.Name = "grp_islemler";
            this.grp_islemler.Size = new System.Drawing.Size(143, 211);
            this.grp_islemler.TabIndex = 4;
            this.grp_islemler.TabStop = false;
            this.grp_islemler.Text = "işlemler";
            // 
            // btn_yenikayit
            // 
            this.btn_yenikayit.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.btn_yenikayit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_yenikayit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_yenikayit.Location = new System.Drawing.Point(15, 46);
            this.btn_yenikayit.Name = "btn_yenikayit";
            this.btn_yenikayit.Size = new System.Drawing.Size(112, 36);
            this.btn_yenikayit.TabIndex = 0;
            this.btn_yenikayit.Text = "yeni kayıt";
            this.btn_yenikayit.UseVisualStyleBackColor = true;
            this.btn_yenikayit.Click += new System.EventHandler(this.btn_yenikayit_Click);
            // 
            // btn_liste
            // 
            this.btn_liste.Location = new System.Drawing.Point(15, 88);
            this.btn_liste.Name = "btn_liste";
            this.btn_liste.Size = new System.Drawing.Size(112, 36);
            this.btn_liste.TabIndex = 0;
            this.btn_liste.Text = "kayıt listele";
            this.btn_liste.UseVisualStyleBackColor = true;
            this.btn_liste.Click += new System.EventHandler(this.btn_liste_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.Location = new System.Drawing.Point(15, 130);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(112, 36);
            this.btn_kapat.TabIndex = 0;
            this.btn_kapat.Text = "uygulama kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_zaman);
            this.panel2.Location = new System.Drawing.Point(854, 413);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 37);
            this.panel2.TabIndex = 3;
            // 
            // lbl_zaman
            // 
            this.lbl_zaman.AutoSize = true;
            this.lbl_zaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_zaman.Location = new System.Drawing.Point(12, 10);
            this.lbl_zaman.Name = "lbl_zaman";
            this.lbl_zaman.Size = new System.Drawing.Size(159, 18);
            this.lbl_zaman.TabIndex = 0;
            this.lbl_zaman.Text = "16.03.2023 09:12:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BuyukOrnek.Properties.Resources.yoda;
            this.pictureBox1.Location = new System.Drawing.Point(25, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1056, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Anaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "yapilacak listesi";
            this.Load += new System.EventHandler(this.Anaform_Load);
            this.panel1.ResumeLayout(false);
            this.grp_islemler.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grp_islemler;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_liste;
        private System.Windows.Forms.Button btn_yenikayit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_zaman;
        private System.Windows.Forms.Timer timer1;
    }
}

