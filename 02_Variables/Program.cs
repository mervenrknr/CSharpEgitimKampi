using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //Console.OutputEncoding = System.Text.Encoding.Unicode;
            ////double number;
            ////number = 4.85; //>> ondalık sayılar ekran çıktısında virgüllü şekilde karşımıza çıkar.
            ////Console.WriteLine(number);

            //Console.WriteLine("***Fiyat Listesi***");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice =20.95;
            //strawberryPrice = 45;
            //potatoPrice  = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + "₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice+ "₺" );
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice+"₺");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + "₺");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + "₺");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram,orangeGram, strawberryGram,potatoGram,tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859; 
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double  orangeTotalPrice= orangeGram * orangePrice;
            //double  strawberryTotalPrice= strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;




            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün: Elma --Birim Fiyatı:" + applePrice+ " --Ölçülen Gramaj:"+appleGram+" --Toplam Ücret:"+ appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal --Birim Fiyatı:" + orangePrice+ " --Ölçülen Gramaj:"+orangeGram+" --Toplam Ücret:"+ orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek --Birim Fiyatı:" + strawberryPrice+ " --Ölçülen Gramaj:"+strawberryGram+" --Toplam Ücret:"+ strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates --Birim Fiyatı:" + tomatoPrice+ " --Ölçülen Gramaj:"+tomatoGram+" --Toplam Ücret:"+ tomatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates --Birim Fiyatı:" + potatoPrice+ " --Ölçülen Gramaj:"+potatoGram+" --Toplam Ücret:"+ potatoTotalPrice);

            //double shoppingTotalPrice=appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+tomatoTotalPrice+potatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice+"₺");




            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //char symbol; //>> char ifadesinde değişkenler tek tırnak ile atanır ve tek bir harften oluşur
            //symbol = 'a';



            #endregion

            #region Klavyeden Veri Girişleri string değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,
            //     passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("şehir bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();
            //Console.WriteLine("-------------------------");
            //Console.WriteLine("Yolcu TC Kimlik Numarası: "+passengerIdentityNumber +" Yolcu Ad Soyad "+passengerName+" "+passengerSurname+" "+
            //    passengerDistrict+" / "+passengerCity+" "+passengerAge+" ") ;

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shorCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen kaç adet ayakkabı aldığınızı giriniz:");
            //shorCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen kaç adet bilgisayar aldığınızı giriniz:");
            //computerCount= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen kaç adet sandalye aldığınızı giriniz:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen kaç adet televizyon aldığınızı giriniz:");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=shorCount*shoePrice+computerCount*computerPrice+chairCount*chairPrice+tvCount*tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: "+ totalPrice);


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3,result;
            //Console.Write("lÜTFEN 1. SINAV NOTUNU GİRİNİZ: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("lÜTFEN 2. SINAV NOTUNU GİRİNİZ: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("lÜTFEN 3. SINAV NOTUNU GİRİNİZ: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();

            //Console.Write("Sınav ortalamanız: " + result);



            #endregion

            #region Klavyeden karakter girişleri
            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);


            #endregion
            Console.Read();

        }
    }
}
