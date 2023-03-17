using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BuyukOrnek
{
    public class ToDoClass
    {
        public Guid id { get; set; }

        [DisplayName("Başlık")]//bu şekilde attribute ekliyor ve baslik ismini Başlık yaptık diğerlerini de bu şekilde değiştirebiliriz
        public string baslik { get; set; }
        public string ozet { get; set; }
        public string aciklama { get; set; }
        public int onemderece { get; set; }
        public string durum { get; set; }
        public DateTime kayittarihi { get; set; }


    }
}
