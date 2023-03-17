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
    public partial class Kayitlistesi : Form
    {
        private string tamamlandi;

        public Kayitlistesi()
        {
            InitializeComponent();
        }

        

        private void btn_tamamlandi_Click(object sender, EventArgs e)
        {

            dgv_kayitliste.DataSource = sanaldatabase.todolist.Where(i =>i.durum == "Tamamlandı").ToList();
            //dgv_kayitliste.datasource ile data gridview everi atabiliyoruz yukarıda koşul ile tamamlandıyı filtreleyerek to list ettik yazmazsak string olmuyor hatası verir
             


        }

        private void btn_beklemede_Click(object sender, EventArgs e)
        {
            dgv_kayitliste.DataSource = sanaldatabase.todolist.Where(i => i.durum == "Beklemede").ToList();
        }

        private void btn_tamamlanmadi_Click(object sender, EventArgs e)
        {
            dgv_kayitliste.DataSource = sanaldatabase.todolist.Where(i => i.durum == "Tamamlanmadı ").ToList();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            dgv_kayitliste.DataSource = sanaldatabase.todolist.Where(i => i.durum == "İptal edildi ").ToList();
        }

        private void btn_ertelendi_Click(object sender, EventArgs e)
        {
            dgv_kayitliste.DataSource = sanaldatabase.todolist.Where(i => i.durum == "Ertelendi").ToList();
        }


        private void Kayitlistesi_Load(object sender, EventArgs e)
        {
            dgv_kayitliste.DataSource = sanaldatabase.todolist;
            dgv_kayitliste.Columns[0].Visible = false;//bunusadece yazsak çalışmaz çünkü ilk liste dolar sonra bakar ama liste olmazsa çıkmaz bir şey
        }
    }
}
