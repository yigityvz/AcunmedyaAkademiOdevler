using Ödev1.İnterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev1.Class
{
    public class BMW : Araba, IHizli, IYuzuyor,IUcuyor
    {
        public void hizliGidiyor(string isim)
        {
            Console.WriteLine(isim + " : Çok hızlı gider ");
        }

        public void yuzuyor(string isim)
        {
            Console.WriteLine(isim + " : Denizde yüzüyor ");
        }

        public void ucuyor(string isim)
        {
            Console.WriteLine(isim + " : Havada uçar ");
        }


    }
}
