using Ödev1.İnterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev1.Class
{
    public class Mercedes : Araba, IYuzuyor, IUcuyor
    {
        public void ucuyor(string isim)
        {
            Console.WriteLine(isim + " : Havada uçar ");
        }

        public void yuzuyor(string isim)
        {
            Console.WriteLine(isim + " : Denizde yüzüyor ");
        }
    }
}
