using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyukOrnek
{
    public partial class ToDo : Form
    {
        public ToDo()
        {
            InitializeComponent();
        }

        private void txt_baslik_Enter(object sender, EventArgs e)
        {
            TextBox T = sender as TextBox;
            T.BackColor = Color.Blue;
        }

        private void txt_baslik_Leave(object sender, EventArgs e)
        {
            TextBox T = sender as TextBox;
            T.BackColor = Color.White;
        }

        private void cmb_durumu_Enter(object sender, EventArgs e)
        {
            ComboBox T = sender as ComboBox;
            T.BackColor= Color.DeepSkyBlue;
        }

        private void cmb_durumu_Leave(object sender, EventArgs e)
        {
            ComboBox T = sender as ComboBox;
            T.BackColor = Color.Wheat;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
           int sonuc = sanaldatabase.KayitEkle(new ToDoClass() // kayit ekle fonksiyonu try catch ile bool tipte 1,0 döndürdüğü için int sonuc atılabildi
            {
                baslik = txt_baslik.Text,
                aciklama = txt_aciklama.Text,
                id = Guid.NewGuid(),// benzersiz kod oluşturur guid ile
                onemderece =int.Parse(txt_onem.Text), //propertylerde (int) koyarak başına dönüşüm yapamıyoruz değişkenlerde oluyor ama
                ozet = txt_ozetbilgi.Text,
                durum = cmb_durumu.SelectedItem.ToString(),
                kayittarihi = DateTime.Now


            });
            if (sonuc == 1)
            {
                MessageBox.Show("kayit ekleme işlemi başarılı","bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
               DialogResult cvp = MessageBox.Show("yeni kayıt eklemek ister misiniz ?", "yeni kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cvp == DialogResult.Yes)
                {
                    foreach (Control item in Controls)// control içinde groupbox formuna a erişti eğer yeni kayıt eklersek cvp yes ise textleri siliyor burası
                    {
                      if (item is TextBox)
                      {
                        item.Text = string.Empty;
                      }

                        
                    }
                }
                else
                {
                    Kayitlistesi k1 = new Kayitlistesi();


                    if (Application.OpenForms["Kayitlistesi"] != null) // burada yeniden yeni kayıt bastığımızda var olana odaklansın üst üste yenisini açmasın diye if koşulu ile focus yaptık
                    {
                        k1 = (Kayitlistesi)Application.OpenForms["Kayitlistesi"];
                       DataGridView dgv = (DataGridView)((GroupBox)k1.Controls["Kayitlistesi"]).Controls["dgv_kayitlistesi"]; //burada yeni kayıt ekledğimizde kendini yenilesin diye eriştik fomru silip yeniden doldurttuk böylece yenilenmiş oldu
                        dgv.DataSource = null;
                        dgv.DataSource = sanaldatabase.todolist;
                        k1.Focus();
                    }
                    else
                    {
                        k1 = new Kayitlistesi();
                        k1.MdiParent = Application.OpenForms["AnaForm"];
                        k1.StartPosition = FormStartPosition.CenterScreen;
                        k1.Show();

                    }
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("kayıt ekleme işleminde hata", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                                       
            
        }
    }
}
