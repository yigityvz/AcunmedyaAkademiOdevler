using Ödev2.Abstract_Class;

genelMudur gm = new genelMudur();
Mudur m = new Mudur();
Programcı p = new Programcı();
Stajyer s = new Stajyer();

double toplamMaas = 0;

toplamMaas += gm.maasinizNedir();
toplamMaas += m.maasinizNedir();
toplamMaas += p.maasinizNedir();
toplamMaas += s.maasinizNedir();

gm.maasHesapla(toplamMaas);
