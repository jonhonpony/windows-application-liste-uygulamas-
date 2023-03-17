namespace BuyukOrnek
{
    partial class ToDo
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
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.txt_baslik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ozetbilgi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_onem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.cmb_durumu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.AutoSize = true;
            this.lbl_baslik.Location = new System.Drawing.Point(11, 19);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(44, 16);
            this.lbl_baslik.TabIndex = 0;
            this.lbl_baslik.Text = "Başlık";
            // 
            // txt_baslik
            // 
            this.txt_baslik.Location = new System.Drawing.Point(112, 19);
            this.txt_baslik.Name = "txt_baslik";
            this.txt_baslik.Size = new System.Drawing.Size(168, 22);
            this.txt_baslik.TabIndex = 1;
            this.txt_baslik.Enter += new System.EventHandler(this.txt_baslik_Enter);
            this.txt_baslik.Leave += new System.EventHandler(this.txt_baslik_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Özet Bilgi";
            // 
            // txt_ozetbilgi
            // 
            this.txt_ozetbilgi.Location = new System.Drawing.Point(112, 47);
            this.txt_ozetbilgi.Multiline = true;
            this.txt_ozetbilgi.Name = "txt_ozetbilgi";
            this.txt_ozetbilgi.Size = new System.Drawing.Size(168, 78);
            this.txt_ozetbilgi.TabIndex = 1;
            this.txt_ozetbilgi.Enter += new System.EventHandler(this.txt_baslik_Enter);
            this.txt_ozetbilgi.Leave += new System.EventHandler(this.txt_baslik_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Açıklama";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(112, 131);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(168, 80);
            this.txt_aciklama.TabIndex = 1;
            this.txt_aciklama.Enter += new System.EventHandler(this.txt_baslik_Enter);
            this.txt_aciklama.Leave += new System.EventHandler(this.txt_baslik_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Önem Derecesi";
            // 
            // txt_onem
            // 
            this.txt_onem.Location = new System.Drawing.Point(112, 217);
            this.txt_onem.Name = "txt_onem";
            this.txt_onem.Size = new System.Drawing.Size(168, 22);
            this.txt_onem.TabIndex = 1;
            this.txt_onem.Enter += new System.EventHandler(this.txt_baslik_Enter);
            this.txt_onem.Leave += new System.EventHandler(this.txt_baslik_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Durumu";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(112, 307);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(168, 38);
            this.btn_kaydet.TabIndex = 2;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // cmb_durumu
            // 
            this.cmb_durumu.FormattingEnabled = true;
            this.cmb_durumu.Items.AddRange(new object[] {
            "Beklemede",
            "Tamamlandı",
            "Tamamlanamadı",
            "İptal edildi",
            "Ertelendi"});
            this.cmb_durumu.Location = new System.Drawing.Point(112, 245);
            this.cmb_durumu.Name = "cmb_durumu";
            this.cmb_durumu.Size = new System.Drawing.Size(168, 24);
            this.cmb_durumu.TabIndex = 3;
            this.cmb_durumu.Enter += new System.EventHandler(this.cmb_durumu_Enter);
            this.cmb_durumu.Leave += new System.EventHandler(this.cmb_durumu_Leave);
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 378);
            this.Controls.Add(this.cmb_durumu);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_onem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ozetbilgi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_baslik);
            this.Controls.Add(this.lbl_baslik);
            this.Name = "ToDo";
            this.Text = "ToDo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_baslik;
        private System.Windows.Forms.TextBox txt_baslik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ozetbilgi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_onem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.ComboBox cmb_durumu;
    }
}