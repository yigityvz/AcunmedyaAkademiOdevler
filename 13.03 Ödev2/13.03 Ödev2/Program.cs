using _13._03_Ödev2;

Araba a = new Araba();
int gelenYas = a.yilHesapla(1980);

if (gelenYas > 0 && gelenYas < 10)
{
    Console.WriteLine("arabanız yeni");
}
else if (gelenYas > 10 && gelenYas < 20)
{
    Console.WriteLine("servise götürmeniz gerekebilir");
}
else if (gelenYas > 20 && gelenYas < 30)
{
    Console.WriteLine("arabanız hurdaya çıkabilir");
}
else
{
    Console.WriteLine("Ya hiç üretilmedi ya da trafikten men edilmiştir");
}