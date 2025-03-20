using _20_03_25_Ödev1.Constructor;

Kapı kapı = new Kapı(4);
Kasa kasa = new Kasa("sedan");
Pencere pencere = new Pencere(4);
Fiyat fiyat = new Fiyat(2000000);
Araba araba = new Araba(kapı, kasa, fiyat, pencere);
YeniAraba yeni = new YeniAraba(araba, "BMW", "X5");
yeni.yazdir();

