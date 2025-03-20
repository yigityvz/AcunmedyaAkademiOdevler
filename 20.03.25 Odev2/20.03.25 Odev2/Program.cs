using _20._03._25_Odev2;

Matematik matematik = new Matematik();

int toplama1 = matematik.Topla(10, 20);
int toplama2 = matematik.Topla(10, 20, 30);


Console.WriteLine("2 Sayı Toplamı: " + toplama1);
Console.WriteLine("3 Sayı toplamı: " + toplama2);




double carpma1 = matematik.Carp(1.5, 2.5);
double carpma2 = matematik.Carp(1.5, 2.5, 3.5);

Console.WriteLine("2 Sayı çarpımı: " + carpma1);
Console.WriteLine("3 Sayı çarpımı: " + carpma2);
