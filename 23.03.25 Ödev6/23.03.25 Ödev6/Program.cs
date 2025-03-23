Random random = new Random();
int targetNumber = random.Next(1, 101); // 1 ile 100 arasında rastgele sayı oluştur
int guess = 0;
int attempts = 0;

Console.WriteLine("Sayı Tahmin Oyununa Hoş Geldiniz! 1 ile 100 arasında bir sayı tahmin edin.");

while (guess != targetNumber)
{
    Console.Write("Tahmininiz: ");

    while (!int.TryParse(Console.ReadLine(), out guess))
    {
        Console.Write("Geçerli bir sayı giriniz: ");
    }

    attempts++;

    if (guess < targetNumber)
    {
        Console.WriteLine("Daha büyük bir sayı girin!");
    }
    else if (guess > targetNumber)
    {
        Console.WriteLine("Daha küçük bir sayı girin!");
    }
}

Console.WriteLine($"Tebrikler! {attempts} denemede doğru tahmini yaptınız.");
