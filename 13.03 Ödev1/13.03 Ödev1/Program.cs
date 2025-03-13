using _13._03_Ödev1;

Insan i = new Insan();
int gelenYas = i.yasHesapla(1980);

if (gelenYas > 0 && gelenYas < 18)
{
    Console.WriteLine("küçüksünüz");
}
else if (gelenYas > 18 && gelenYas < 35)
{
    Console.WriteLine("gençsiniz");
}
else if (gelenYas > 35 && gelenYas < 55)
{
    Console.WriteLine("yetişkinsiniz");
}
else if (gelenYas > 55 && gelenYas < 75)
{
    Console.WriteLine("yaşlısınız");
}
else if (gelenYas > 75 && gelenYas < 99)
{
    Console.WriteLine("çok yaşlısınız");
}
else
{
    Console.WriteLine("Ya hiç doğmadınız ya da çoktan öldünüz");
}