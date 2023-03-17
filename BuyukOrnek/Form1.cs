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
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }

        private void Anaform_Load(object sender, EventArgs e)
        {
            timer1.Interval= 1000;//timer ın değişme zamanını seçiyoruz
            timer1.Tick += timer1_tick; //timer tetiklendiğinde zamanı yazmasını istiyoruz
            timer1.Start();

            GirisForm girisForm = new GirisForm(); // giriş formu ana form içinde göstermek için
            girisForm.MdiParent= this;//showdan önce bunun parenti hengisi onu belirlemek lazım ona da this dedik
            girisForm.StartPosition = FormStartPosition.Manual;
            girisForm.Show();

        }

        private void timer1_tick(object sender, EventArgs e)
        {
            lbl_zaman.Text = DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss");
        }

        private void btn_yenikayit_Click(object sender, EventArgs e)
        {
            ToDo toDo;
            
            
            if (Application.OpenForms["ToDo"]!=null) // burada yeniden yeni kayıt bastığımızda var olana odaklansın üst üste yenisini açmasın diye if koşulu ile focus yaptık
            {
                toDo = (ToDo)Application.OpenForms["ToDo"]; // normalde bu todo içi boş tipi falan belli sadece biz buu focuslamak için veya işlem yapmak için önce openformsdan yakalayıp sonra içine aktarmamız lazım
                toDo.Focus();
            }
            else
            {
                toDo = new ToDo();
                toDo.MdiParent = this;
                toDo.StartPosition = FormStartPosition.CenterScreen;
                toDo.Show();

            }




        }

        private void btn_liste_Click(object sender, EventArgs e)
        {
            Kayitlistesi k1 = new Kayitlistesi();
           

            if (Application.OpenForms["Kayitlistesi"] != null) // burada yeniden yeni kayıt bastığımızda var olana odaklansın üst üste yenisini açmasın diye if koşulu ile focus yaptık
            {
                k1 = (Kayitlistesi)Application.OpenForms["Kayitlistesi"];
                k1.Focus();
            }
            else
            {
                k1 = new Kayitlistesi();
                k1.MdiParent = this;
                k1.StartPosition = FormStartPosition.Manual;
                k1.Show();

            }
        }
    }
}
