using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // >>sizin kullanacağız kodlara ait kütüphaneleri barındırıyor bu kısım
//>>neye ihtiyacın varsa ilgili kütüphaneyi buraya ekleyeceksin


namespace _01_MainSubject
{
    internal class Program //>>internal erişim belirliyici demektir
    {
        static void Main(string[] args) //>>main bir methoddur parantezlerin içine yazılır. 
        {
            #region yazdırmakomutları

            //    Console.Write("Merhaba dünya"); //>> write yazıldığında imleci en sağa atar 
            //    Console.WriteLine("selam"); // writeline ise en son imleci alt satıra bırakır.

            //Console.WriteLine("***Yemek Kategorileri ***");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");//>> ctrl+D yaparak satırı olduğu gibi kopyalaıp alt satıra yapıştırır
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***Yemek Kategorileri ***");


            //DEĞİŞKENLER

            #endregion

            #region stringDeğişkenler

            //string
            //DEĞİŞKEN_TÜRÜ DEĞİŞKEN_ADI;

            //string name;
            //name = "Merve";
            //Console.WriteLine(name); 

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Ali";
            customerSurname = "Çınar";
            customerPhone = "5358689865";
            customerEmail = "deneme@gmail.com";
            district = "nişantaşı";
            city = "istanbul";

            Console.WriteLine("***Rezervasyon Kartı****");
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Müşteri: "+ customerName + " "+ customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adrsi: " + customerEmail);
            Console.WriteLine("Adres: "+  district+"/"+city);
            Console.WriteLine("------------------------------------");


            #endregion

            #region int değişkenler
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("*** Restoran menü fiyatı");
            Console.WriteLine();
            Console.WriteLine("---Hamburger Fiyatı: " + hamburgerPrice +" TL" );
            Console.WriteLine("---Kola Fiyatı: " + cokePrice +" TL" );
            Console.WriteLine("---Su Fiyatı: " + waterPrice +" TL" );
            Console.WriteLine("--Pizza Fiyatı: " + pizzaPrice +" TL" );
            Console.WriteLine("--Limonata Fiyatı: " + lemonadePrice +" TL" );

            int hamburgercount;
            int cokecount;
            int watercount;
            int pizzacount;
            int lemonadecount;
            int friescount;

            int totalHamburgerPrice= 0;

            hamburgercount = 3;
            watercount = 3;
            friescount = 1;
            lemonadecount = 0;
            pizzacount = 0;

            totalHamburgerPrice = hamburgercount * hamburgerPrice;
            Console.WriteLine("--------------");
            Console.WriteLine("Hamburger tutarı"+" "+ totalHamburgerPrice);




            #endregion


            Console.Read();//>>ben kodu çalıştırdığımda entera basana kadar açık kalmasını sağlayan yöntem.
        }
    }
}

