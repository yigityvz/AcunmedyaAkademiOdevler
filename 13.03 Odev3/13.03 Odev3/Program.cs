using _13._03_Odev3;

Çalışan genelMudur = new Çalışan();
Çalışan mudur = new Çalışan();
Çalışan programci = new Çalışan();
Çalışan stajyer = new Çalışan();

genelMudur.ad = "İsmail";
genelMudur.soyadi = "Yıldız";
genelMudur.meslek = "Genel Müdür";
genelMudur.departman = "Yazılım";
genelMudur.maas = 40000;


mudur.ad = "Akın";
mudur.soyadi = "Baş";
mudur.meslek = "Müdür";
mudur.departman = "Yazılım";
mudur.maas = 35000;

programci.ad = "Teoman";
programci.soyadi = "Ağır";
programci.meslek = "Programcı";
programci.departman = "Yazılım";
programci.maas = 20000;

stajyer.ad = "Yiğit";
stajyer.soyadi = "Tok";
stajyer.meslek = "Stajyer";
stajyer.departman = "Yazılım";
stajyer.maas = 5000;

string[] bilgiler = new string[4];
bilgiler[0] = genelMudur.ad + " " + genelMudur.soyadi + " " + genelMudur.meslek + " " + genelMudur.departman + " " + genelMudur.maas;
bilgiler[1] = mudur.ad + " " + mudur.soyadi + " " + mudur.meslek + " " + mudur.departman + " " + mudur.maas;
bilgiler[2] = programci.ad + " " + programci.soyadi + " " + programci.meslek + " " + programci.departman + " " + programci.maas;
bilgiler[3] = stajyer.ad + " " + stajyer.soyadi + " " + stajyer.meslek + " " + stajyer.departman + " " + stajyer.maas;

// Çalışan bilgilerini yazdırma
for (int i = 0; i < bilgiler.Length; i++)
{
    Console.WriteLine(bilgiler[i]);
}

int toplamMaas = 0;
toplamMaas += genelMudur.maas + mudur.maas + programci.maas + stajyer.maas;
Console.WriteLine("Toplam Maaş: " + toplamMaas);
