using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If

            //Console.WriteLine("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password =="abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");

            //}


            //string capital, country;
            //Console.WriteLine("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital=="ankara" && country=="türkiye" )
            //{
            //    Console.Write("veriler doğrulandı");
            //}
            //else { 
            //    Console.Write("hatalı bilgi");
            //}

            //int sayi;
            //Console.WriteLine("Lütfen bir sayı giriniz: ");
            //sayi=int.Parse(Console.ReadLine());

            //if (sayi==5)
            //{
            //    Console.WriteLine("Sayı doğru ");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı sayı");
            //}

            //double exam1,exam2,exam3,average;
            //string result="Hata! ";

            //Console.Write("Sınav1: ");
            //exam1=int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2=int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3=int.Parse(Console.ReadLine());

            //average=(exam1+exam2+exam3)/3;
            //Console.Write("Sınavların ortalaması: " + average);
            //Console.WriteLine();

            //if (average>0 && average<=50)
            //{
            //    result = "Sonuç vasat az ders çalış buneee";


            //}
            //if (average>50 && average<=70)
            //{
            //    result = "Sonuç orta ehh yaane";

            //}
            //if(average>70 & average<=84)
            //{
            //    result = "Sonuç iyi";

            //}

            //Console.WriteLine(result); //>>result değişkenini tamamlarken hata değerini atamamızın sebebi if parantezlerine uygun olmadığında ekrana o yazıyı getirmesini istediğim içindi.

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city=="ankara" | city=="bursa" | city=="trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");

            //}


            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username=Console.ReadLine();

            //if (username !="admin") //>> bu eşit değildir ifadesi eğer admin dışında bir değer değilse anlamını taşır ve aşağıdaki süslü parantezlerin içerisine girer 
            //{
            //    Console.Write("bu kullanıcı adı kabul edilemez");
            //}
            //else {
            //    Console.Write("Hoş geldiniz: ");
            //}




            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int sonuc = number % 5; //>>(mod alma işlemi dediğimiz şey bir sayının bir sayıya bölümünden arta kalan sayıyı verir)
            //Console.WriteLine(sonuc);

            //Console.Write("Lütfen 1 .sayıyı giriniz: ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz: ");
            //int number2=int.Parse(Console.ReadLine());

            //int result=number1%number2;
            //Console.Write("1.sayının 2.sayıya bölümünden kalan: " + result);

            //Console.WriteLine("Lütfen bir sayı giriniz: ");
            //int number=int.Parse(Console.ReadLine());
            //if (number %2==0 ) {
            //    Console.WriteLine("sayı çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir");
            //}

            #endregion

            #region Char değişkenler ile karar yapıları
            //Console.WriteLine("Takım sembolunu yazınız: ");
            //string team;
            //team =Console.ReadLine();

            //if (team == "F" | team=="f") {
            //    Console.WriteLine("FENERBAHÇE");
            //}
            //else if (team == "G" | team=="g")
            //{
            //    Console.WriteLine("GALATASARAY");
            //}

            #endregion

            #region Örnek proje Uygulaması 
            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("-------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-------------------");

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();
            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Ana Yemekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("------------Ana Yemekler--------- -");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("- -Çorbalar- ");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek çorbası");
            //    Console.WriteLine("2-Ezogelin Çorba");
            //    Console.WriteLine("- --Çorbalar-");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(" --Pizzalar-");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("2Tavuklu Pizza");
            //    Console.WriteLine("- ---Pizzalar-");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(". -İçecekler--");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("- --İçecekler--");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("- -Tatlılar- ");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trilice");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("---------Tatlılar----");
            //    Console.WriteLine();
            //}





            #endregion

            #region switch case örneği 
            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            ////    default: Console.Write("Hatalı Veri Girişi"); break;

            //}
            #endregion

            #region switch case ile Hesap Makinesi

            //double result;
            //Console.WriteLine("1.sayıyı giriniz: ");
            //double sayi1=double.Parse(Console.ReadLine());
            //Console.WriteLine("2.sayıyı giriniz: ");
            //double sayi2=double.Parse(Console.ReadLine());
            //Console.WriteLine("Yapmak istediğiniz işlemi sembolunu yazınız: ");
            //string islem=Console.ReadLine();
            
            //switch (islem)
            //{
            //    case "+":
            //        result=sayi1+sayi2; 
            //        Console.WriteLine("Toplama işleminin sonucu: "+result);
            //        break;
            //    case "-":
            //        result=sayi1-sayi2;
            //        Console.WriteLine("Çıkarma işleminin sonucu: " + result);
            //        break;
            //    case "*":
            //        result=sayi1* sayi2;
            //        Console.WriteLine("Çarpma işleminin sonucu: " + result);
            //        break;

            //    default:
            //        Console.WriteLine("Hatalı giriş.");
            //        break;
            //}
            
            


            #endregion

            Console.Read();
            }
    }
}