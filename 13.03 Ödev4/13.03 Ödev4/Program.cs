using _13._03_Ödev4;

Araba a = new Araba();  
Araba b = new Araba();  
Araba c = new Araba();


a.model = "BMW";
b.model = "Porsche";
c.model = "Mercedes";

a.benzin = 20;
b.benzin = 30;
c.benzin = 40;

string[] bilgiler = new string[3];
bilgiler[0] = a.model + " " + a.benzin;
bilgiler[1] = b.model + " " + b.benzin;
bilgiler[2] = c.model + " " + c.benzin;

for(int i = 0; i < bilgiler.Length; i++)
{
    Console.WriteLine(bilgiler[i]);
}
int toplamBenzin = 0;
toplamBenzin += a.benzin + b.benzin + c.benzin;
Console.WriteLine("Toplam benzin = " + toplamBenzin);
