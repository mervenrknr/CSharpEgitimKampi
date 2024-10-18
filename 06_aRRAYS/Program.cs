using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_aRRAYS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel dizi örnekleri
            //Dzilerin sytax yapısı 
            //Değişken türü[] DiziAdı= new DeğişkenTürü[elaman sayısı]

            //string[] colors = new string[5]; //>> [] işareti sisteme dizilerden bashettiğini belirtmiş oldu
            //{
            //    colors[0] = "kırmızı";
            //    colors[1] = "sarı";
            //    colors[2] = "beyaz";
            //    colors[3] = "mor";
            //    colors[4] = "turuncu";

            ////    Console.WriteLine(colors[4]);
            //}

            #endregion

            #region dizideli tüm elemanları yazdıran program

            //string[] meyveler = { "elma", "portakal", "limon", "muz" };

            //for (int i = 0; i < meyveler.Length; i++)
            //{
            //    Console.Write(meyveler[i] + " ");
            //}


            //int[] myarray = { 47, 89, 56, 63, 89, 46, 100, 352 };

            //int buyuksayi = myarray[0];

            //for (int i = 0; i < myarray.Length; i++)
            //{
            //    if (myarray[i] > buyuksayi)
            //    {
            //        buyuksayi = myarray[i];
            //    }
            //}
            //Console.WriteLine(buyuksayi);
            #endregion


            #region dizilerde methotlar

            //string[] persons = { "merve", "buse", "elif", "yılmaz", "sinem" };
            //Console.WriteLine(persons.Length); //>> length methodu dizinin kaç elemanlı olduğunu gösterir


            //int[] number = { 1, 2, 3, 89, 75, 45 };

            //Array.Sort(number); // array sort methodu küçükten büyüğe sıralamaya yarar
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}



            //int[] number = { 1, 2, 3, 89, 75, 45 };

            //Array.Reverse(number); //>>> Array reverse dizideki tğm elemanları ters şekilde yenidden yazdırmaya yarar
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            //string[] persons = { "ali", "buse", "ayşegül", "kaya" };

            //int index = Array.IndexOf(persons,"kaya"); //>> dizide aradığınız bir kelimenin kaçını indexte olduğunu söyleyen method
            //Console.WriteLine(index);


            //int[] numbers = { 1, 2, 56, 89, 75, 41, 36, 99, 8822, 456, 79364, 4545, 78513 };
            //Console.WriteLine("dizinin en büyük elemanı: " + numbers.Max());//>>> dizinin içindeki en büyük elemanı söyler
            //Console.WriteLine("dizinin en küçük elemanı: "+numbers.Min());//>> dinizn en küçük elemanı söyler


            #endregion

            #region Kullanıcıdan değer alma
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine("şehir ismi giriniz: ");
            //    string eleman=Console.ReadLine();
            //    cities[i] = eleman;

            //}

            //Console.WriteLine(cities[3]);

            //int[] numbers = { 1, 50, 36, 56, 23, 89 };

            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];

            //Console.WriteLine(sum);
            //}



            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 0 };
            //Console.WriteLine("çift sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i]%2==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

             
            //}

            //Console.WriteLine("tek sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }


            //}

            #endregion

            Console.Read();
        }
    }
}
