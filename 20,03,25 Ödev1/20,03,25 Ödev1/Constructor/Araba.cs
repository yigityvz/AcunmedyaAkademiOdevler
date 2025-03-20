using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_03_25_Ödev1.Constructor
{
    public class Araba
    {
        public Fiyat fiyat;
        public Kapı kapı;
        public Kasa kasa;
        public Pencere pencere;

        public Araba(Fiyat fiyat, Kapı kapı, Kasa kasa, Pencere pencere)
        {
            this.fiyat = fiyat;
            this.kapı = kapı;
            this.kasa = kasa;
            this.pencere = pencere;
        }

        public Araba(Kapı kapı, Kasa kasa, Fiyat fiyat, Pencere pencere)
        {
            this.kapı = kapı;
            this.kasa = kasa;
            this.fiyat = fiyat;
            this.pencere = pencere;
        }
    }

}
