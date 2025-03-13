using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._03_Ödev2
{
    public class Araba
    {
        public int yilHesapla(int yıl)
        {
            int arabaYili = 0;
            arabaYili= DateTime.Now.Year - yıl;
            return arabaYili;
        }
    }
}
