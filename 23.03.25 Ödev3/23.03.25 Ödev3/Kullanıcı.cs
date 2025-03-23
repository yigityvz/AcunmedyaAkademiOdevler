using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._03._25_Ödev3
{
    public class Kullanıcı
    {
        private string adSoyad;
        private int yas;
        public string email { get; set; }

        public string GetAdSoyad()
        {
            return adSoyad;
        }

        public void SetAdSoyad(string ad)
        {
            adSoyad = ad;
        }

        public int GetYas()
        {
            return yas;
        }

        public void SetYas(int age)
        {
            if (age > 0)
                yas = age;
            else
                Console.WriteLine("Yaş negatif olamaz!");
        }

        public void BilgileriGoster()
        {
            Console.WriteLine("Ad Soyad:" + adSoyad + "Yaş:" + yas + "Email:" + email);
        }
    }
}
