Console.WriteLine("Basit Hesap Makinesi");
Console.Write("Birinci sayıyı girin: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayıyı girin: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Yapmak istediğiniz işlemi girin (+, -, *, /): ");
char operation = Convert.ToChar(Console.ReadLine());

switch (operation)
{
    case '+':
        Console.WriteLine($"Sonuç: {num1} + {num2} = {num1 + num2}");
        break;
    case '-':
        Console.WriteLine($"Sonuç: {num1} - {num2} = {num1 - num2}");
        break;
    case '*':
        Console.WriteLine($"Sonuç: {num1} * {num2} = {num1 * num2}");
        break;
    case '/':
        if (num2 != 0)
            Console.WriteLine($"Sonuç: {num1} / {num2} = {(double)num1 / num2:F2}");
        else
            Console.WriteLine("Hata: Bir sayı 0'a bölünemez!");
        break;
    default:
        Console.WriteLine("Geçersiz işlem!");
        break;
}