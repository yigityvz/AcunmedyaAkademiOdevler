


int[] sayilar = { 10, 20, 30, 40, 50 };
int toplam = 0;


foreach (int sayi in sayilar)
{
    toplam += sayi;
}

double ortalama = toplam / 5.0;


Console.WriteLine("Girilen sayıların toplamı:" +  toplam);
Console.WriteLine("Sayıların ortalaması:" + ortalama);
    
