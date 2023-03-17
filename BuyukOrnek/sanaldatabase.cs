using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukOrnek
{
    internal class sanaldatabase
    {
        public static List<Kullanici> kullanicilar= new List<Kullanici>();
        public static List<ToDoClass> todolist= new List<ToDoClass>();

        static sanaldatabase()// ctor a yazmamızın sebebi girişformda çalışacağı zaman ilk buraya baksın bununla çalışsın diye
        {
            kullanicilar.Add(new Kullanici() { ID = Guid.NewGuid() , KullaniciAd = "admin" , Sifre = "admin"});



        }

        public static int KayitEkle(ToDoClass item)// kayıt edip etmediğimizi kontrol ediyoruz kaydederken
        {
            try
            {
                todolist.Add(item);
                return 1;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
            

        }


    }
}
