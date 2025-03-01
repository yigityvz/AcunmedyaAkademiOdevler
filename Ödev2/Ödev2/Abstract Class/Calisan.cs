using Ödev2.İnterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2.Abstract_Class
{
    public abstract class Calisan : IMaas
    {
        public double maasHesapla(double maas)
        {
            Console.WriteLine("Toplam maaş: " + maas);
            return maas;
        }

        

        public abstract double maasinizNedir();
    }


}
