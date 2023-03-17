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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void txt_kullaniciadi_Enter(object sender, EventArgs e)
        {
            TextBox T = sender as TextBox;
            T.BackColor = Color.Blue;
        }

        private void txt_kullaniciadi_Leave(object sender, EventArgs e)
        {

            TextBox T = sender as TextBox;
            T.BackColor = Color.BurlyWood;

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_kullaniciadi.Text) && !string.IsNullOrEmpty(txt_sifre.Text)) // buranın if kısmı kontrol edilen yer boş mu değil mi ona bakmamızı istiyor
            {
                Kullanici k = sanaldatabase.kullanicilar.FirstOrDefault(i => i.KullaniciAd == txt_kullaniciadi.Text && i.Sifre == txt_sifre.Text); // firstordefault kullanıcı getirdiğinden bu koşul ile kullanici adı kısmı txt deki admine eşit mi diye bakıldı şifre için de aynı bunu contains ile de yaoabilirdik

                if (k != null)
                {
                   Form f = Application.OpenForms["AnaForm"];// form çağrıldı
                    Panel p = (Panel)f.Controls["panel1"];//controls den panele ulaşıldı kolay olsun diye panel türünde p ye bir atama yapıldı
                    GroupBox G1 = (GroupBox)p.Controls["grp_islemler"];// burada koşula göre işlem yapıldı ise arka formdaki butonları aktif etmek istiyoruz bu yüzden önce formu çağırıp içinde ilk panele gidip sonra controls ile panel içinde ki group box a eriştik ve onu aktif ettik 
                    G1.Enabled = true;
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("kullanıcı adı ve şifre boş geçilemez");
                }


            }
           
              
        }
    }
}
