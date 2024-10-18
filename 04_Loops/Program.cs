using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //int mod;
            //int i;
            //for(i=3;i<=50;i+=3)
            //{
            //        Console.WriteLine(i);

            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for (int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("yaşasın cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile karar yapıları

            //for (int i = 1;i<=100;i++)
            //{

            //    if (i%5==0)
            //    {
            //        Console.WriteLine( i);
            //    }

            //}

            //int totalvalue = 0;
            //for (int i = 0; i<=10; i++)
            //{
            //    totalvalue += i;
            //}
            //Console.WriteLine(totalvalue);

            //Console.Read();

            //int totalvalue=0;
            //for (int i = 0;i<20;i++) { 
            //    if (i % 2 == 0)
            //    {


            //        totalvalue += i;
            //        Console.WriteLine(i); 
            //    }


            //}
            //Console.WriteLine(totalvalue);

            // 1 ile 50 arasında 7 ye bölünen kaç adet sayı var


            //int count = 0;

            //for (int i = 1; i < 50; i++)
            //{
            //    if (i%7==0)
            //    {
            //          count++;


            //    }
            //}
            //Console.WriteLine(count);

            //Bir labaratuvarda yapılan deneye göre bakteriler her saat başı x2 şeklinde artış sağlamaktadır. 24 saat içerisinde labaratuvarda olacak bakteri sayısı kaçtır. 


            //int bakteri = 1;
            //for (int i = 1; i<=24; i++)
            //{
            //    bakteri *= 2; 
            //    Console.WriteLine(i+". saatin sonunda "+bakteri+" üremiştir");


            //}

            //Console.WriteLine("--------");
            //Console.WriteLine("24 saatin sonunda toplam üreyen bakteri sayısı: "+bakteri);
            #endregion


            #region While Döngüsü
            //while(şart)
            //{
            //işlemler
            //} for yapısının dağınık hali diyebiliriz

            //int i = 1;

            //while (i <=10)
            //{
            //    Console.WriteLine("Merhaba döngüler");
            //    i++;
            //}

            //1 le 10 arasında 3e tam bölünebilen sayılar

            //int i=1;
            //while (i < 10)
            //{
            //    if(i%3==0)
            //    {
            //        Console.WriteLine(i);

            //    }
            //    i++;
            //}


            #endregion
             
            #region Örnek sınav sorusu
            //klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız

            //Console.WriteLine("3 basamaklı bir sayı giriniz: ");
            //int sayi=int.Parse(Console.ReadLine());

            //int birlerb, onlarb, yuzlerb,toplam;

            //birlerb = sayi % 10;
            //yuzlerb= sayi / 100;
            //onlarb = (sayi % 100) / 10;
            //toplam = birlerb + onlarb + yuzlerb;

            //Console.WriteLine(sayi + " sayısının birler basamağı: " + birlerb);
            //Console.WriteLine(sayi + " sayısının onlar basamağı: " + onlarb);
            //Console.WriteLine(sayi + " saysının yüzler basamağı: " + yuzlerb);
            //Console.WriteLine(sayi + "nın rakamlarının toplamı: " + toplam);



            #endregion
            Console.Read();
        } 
    }
}
 