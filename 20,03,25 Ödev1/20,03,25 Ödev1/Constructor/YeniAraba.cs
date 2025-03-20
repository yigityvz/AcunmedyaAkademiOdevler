using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_03_25_Ödev1.Constructor
{
    public class YeniAraba
    {
        public Araba araba;
        public string marka;
        public string model;

        public YeniAraba(Araba araba, string marka, string model)
        {
            this.araba = araba;
            this.marka = marka;
            this.model = model;
        }

        public void yazdir()
        {
            Console.WriteLine("Arabanın markası:" + marka +
                               " modeli: " + model +
                                " kapı sayısı: " + araba.kapı.kap +
                                " pencere sayısı: " + araba.pencere.pen +
                                " kasası: " + araba.kasa.kasası +
                                " fiyatı : " + araba.fiyat.fiyatı);
        }
    }
}
