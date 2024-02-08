
using Business.Concrete;

string ad = "Sultan";
string soyad = "Karanecmiye";
int dogumYili = 2001;
long tcNo = 22123212513;

/*degiskenler();

static void degiskenler()
{
    string mesaj = "Merhaba";
    double tutar = 100000;
    int sayi = 100;
    bool loginTest = false;

    string ad = "Sultan";
    string soyad = "Karanecmiye";
    int dogumYili = 2001;
    long tcNo = 22123212513;

    Console.WriteLine(tutar * 1.18);

    Console.WriteLine(tutar * 1.18);
} */

Vatandas vatandas1 = new Vatandas();
SelamVer("Selam");
SelamVer(isim: "İmdat");
SelamVer();
int sonuc = topla();

string ogrenci1 = "Engin";
string ogrenci2 = "Osman";
string ogrenci3 = "Halime";


string[] ogrenciler = new string[3];
ogrenciler[0] = ogrenci1;
ogrenciler[1] = ogrenci2;
ogrenciler[2] = ogrenci3;

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Adana", "Manisa", "Diyarbakır" };


foreach (var sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string> { "Ankara", "İzmir", "İstanbul" };
yeniSehirler1.Add("Adıyaman");

static void SelamVer (string isim= "NoName")
{
    Console.WriteLine("Merhaba" + isim);
}



static int topla(int sayi1=0, int sayi2=0)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam" + sonuc);
    return sonuc;
}





public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}

PttManager pttManager = new PttManager(new PersonManager());
