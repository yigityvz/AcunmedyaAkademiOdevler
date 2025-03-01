using Ödev3.Abstract_Class;

BMW b = new BMW();
Mercedes m = new Mercedes();
Porcshe p = new Porcshe();

double toplamBenzin = 0;

toplamBenzin += b.kacBenzinHarciyor();
toplamBenzin += m.kacBenzinHarciyor();
toplamBenzin += p.kacBenzinHarciyor();

b.benzinHesapla(toplamBenzin);


