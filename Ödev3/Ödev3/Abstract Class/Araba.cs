using Ödev3.İnterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev3.Abstract_Class
{
    public abstract class Araba : IBenzin
    {
        public double benzinHesapla(double benzin)
        {
            Console.WriteLine("Toplamda " + benzin + " Litre benzin yakıyor");
            return benzin;
        }

        public abstract double kacBenzinHarciyor();
    }
}
