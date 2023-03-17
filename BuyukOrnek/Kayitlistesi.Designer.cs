namespace BuyukOrnek
{
    partial class Kayitlistesi
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ertelendi = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_tamamlanmadi = new System.Windows.Forms.Button();
            this.btn_beklemede = new System.Windows.Forms.Button();
            this.btn_tamamlandi = new System.Windows.Forms.Button();
            this.dgv_kayitliste = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ozetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onemdereceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayittarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDoClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kayitliste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Sienna;
            this.groupBox1.Controls.Add(this.btn_ertelendi);
            this.groupBox1.Controls.Add(this.btn_iptal);
            this.groupBox1.Controls.Add(this.btn_tamamlanmadi);
            this.groupBox1.Controls.Add(this.btn_beklemede);
            this.groupBox1.Controls.Add(this.btn_tamamlandi);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_ertelendi
            // 
            this.btn_ertelendi.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ertelendi.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_ertelendi.Location = new System.Drawing.Point(6, 148);
            this.btn_ertelendi.Name = "btn_ertelendi";
            this.btn_ertelendi.Size = new System.Drawing.Size(188, 23);
            this.btn_ertelendi.TabIndex = 0;
            this.btn_ertelendi.Text = "ertelendi";
            this.btn_ertelendi.UseVisualStyleBackColor = true;
            this.btn_ertelendi.Click += new System.EventHandler(this.btn_ertelendi_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iptal.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_iptal.Location = new System.Drawing.Point(6, 119);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(188, 23);
            this.btn_iptal.TabIndex = 0;
            this.btn_iptal.Text = "iptal edildi";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_tamamlanmadi
            // 
            this.btn_tamamlanmadi.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tamamlanmadi.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_tamamlanmadi.Location = new System.Drawing.Point(6, 90);
            this.btn_tamamlanmadi.Name = "btn_tamamlanmadi";
            this.btn_tamamlanmadi.Size = new System.Drawing.Size(188, 23);
            this.btn_tamamlanmadi.TabIndex = 0;
            this.btn_tamamlanmadi.Text = "tamamlanmadi";
            this.btn_tamamlanmadi.UseVisualStyleBackColor = true;
            this.btn_tamamlanmadi.Click += new System.EventHandler(this.btn_tamamlanmadi_Click);
            // 
            // btn_beklemede
            // 
            this.btn_beklemede.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_beklemede.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_beklemede.Location = new System.Drawing.Point(6, 61);
            this.btn_beklemede.Name = "btn_beklemede";
            this.btn_beklemede.Size = new System.Drawing.Size(188, 23);
            this.btn_beklemede.TabIndex = 0;
            this.btn_beklemede.Text = "beklemede";
            this.btn_beklemede.UseVisualStyleBackColor = true;
            this.btn_beklemede.Click += new System.EventHandler(this.btn_beklemede_Click);
            // 
            // btn_tamamlandi
            // 
            this.btn_tamamlandi.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tamamlandi.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_tamamlandi.Location = new System.Drawing.Point(6, 32);
            this.btn_tamamlandi.Name = "btn_tamamlandi";
            this.btn_tamamlandi.Size = new System.Drawing.Size(188, 23);
            this.btn_tamamlandi.TabIndex = 0;
            this.btn_tamamlandi.Text = "tamamlandı";
            this.btn_tamamlandi.UseVisualStyleBackColor = true;
            this.btn_tamamlandi.Click += new System.EventHandler(this.btn_tamamlandi_Click);
            // 
            // dgv_kayitliste
            // 
            this.dgv_kayitliste.AutoGenerateColumns = false;
            this.dgv_kayitliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kayitliste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.baslikDataGridViewTextBoxColumn,
            this.ozetDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.onemdereceDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn,
            this.kayittarihiDataGridViewTextBoxColumn});
            this.dgv_kayitliste.DataSource = this.toDoClassBindingSource;
            this.dgv_kayitliste.Location = new System.Drawing.Point(219, 24);
            this.dgv_kayitliste.Name = "dgv_kayitliste";
            this.dgv_kayitliste.RowHeadersWidth = 51;
            this.dgv_kayitliste.RowTemplate.Height = 24;
            this.dgv_kayitliste.Size = new System.Drawing.Size(569, 414);
            this.dgv_kayitliste.TabIndex = 1;
          
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // baslikDataGridViewTextBoxColumn
            // 
            this.baslikDataGridViewTextBoxColumn.DataPropertyName = "baslik";
            this.baslikDataGridViewTextBoxColumn.HeaderText = "baslik";
            this.baslikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.baslikDataGridViewTextBoxColumn.Name = "baslikDataGridViewTextBoxColumn";
            this.baslikDataGridViewTextBoxColumn.Width = 125;
            // 
            // ozetDataGridViewTextBoxColumn
            // 
            this.ozetDataGridViewTextBoxColumn.DataPropertyName = "ozet";
            this.ozetDataGridViewTextBoxColumn.HeaderText = "ozet";
            this.ozetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ozetDataGridViewTextBoxColumn.Name = "ozetDataGridViewTextBoxColumn";
            this.ozetDataGridViewTextBoxColumn.Width = 125;
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            this.aciklamaDataGridViewTextBoxColumn.Width = 125;
            // 
            // onemdereceDataGridViewTextBoxColumn
            // 
            this.onemdereceDataGridViewTextBoxColumn.DataPropertyName = "onemderece";
            this.onemdereceDataGridViewTextBoxColumn.HeaderText = "onemderece";
            this.onemdereceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.onemdereceDataGridViewTextBoxColumn.Name = "onemdereceDataGridViewTextBoxColumn";
            this.onemdereceDataGridViewTextBoxColumn.Width = 125;
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "durum";
            this.durumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            this.durumDataGridViewTextBoxColumn.Width = 125;
            // 
            // kayittarihiDataGridViewTextBoxColumn
            // 
            this.kayittarihiDataGridViewTextBoxColumn.DataPropertyName = "kayittarihi";
            this.kayittarihiDataGridViewTextBoxColumn.HeaderText = "kayittarihi";
            this.kayittarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kayittarihiDataGridViewTextBoxColumn.Name = "kayittarihiDataGridViewTextBoxColumn";
            this.kayittarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // toDoClassBindingSource
            // 
            this.toDoClassBindingSource.DataSource = typeof(BuyukOrnek.ToDoClass);
            // 
            // Kayitlistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_kayitliste);
            this.Controls.Add(this.groupBox1);
            this.Name = "Kayitlistesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayitlistesi";
            this.Load += new System.EventHandler(this.Kayitlistesi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kayitliste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoClassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_kayitliste;
        private System.Windows.Forms.Button btn_ertelendi;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_tamamlanmadi;
        private System.Windows.Forms.Button btn_beklemede;
        private System.Windows.Forms.Button btn_tamamlandi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ozetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onemdereceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayittarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource toDoClassBindingSource;
    }
}