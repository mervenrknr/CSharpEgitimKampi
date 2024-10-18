using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach döngüsü

            // Foreach döngüsü(1;2;3;4)
            //1: değişken adı
            //2:değişken adı
            //3:in komutu içinde
            //4: liste,koleks,yon,Dizi
            //foreach ile yapılan her döngü for ile de yapılabilir

            //string[] cities = { "istanbul", "ankara", "samsun", "kastamonu", "sivas" };
            //foreach (string x in cities) //>>x cities dizisinin içine girsin sırasıyla elemanları getirsin demek oluyor
            //{
            //   Console.WriteLine(x);

            //}

            //int[] numbers = { 1, 2, 89, 9896, 9656, 6, 64, 4552, 968, 3462, 685963, };

            //foreach (int sayilar in numbers)
            //{
            //    Console.WriteLine(sayilar);
            //}

            //int[] numbers = { 1, 2, 89, 9896, 9656, 6, 64, 4552, 968, 3462, 685963, };

            //foreach (int number in numbers) {

            //    if (number%2==0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            //Console.WriteLine("çift sayılardır");

            //int[] numbers = { 1, 2, 89, 6, 6, 6, 4 };
            //int sum = 0;
            //foreach (int number in numbers)
            //{
            //    sum += number;
            //}
            //Console.WriteLine(sum);



            #endregion

            #region Listeler

            //List<int> numbers = new List<int>()//>> LİST SYTANX KULLANIM
            //{
            //    2,6,9,78,669
            //};

            //foreach(int x in numbers)
            //{
            //    Console.WriteLine(x); //>> foreach sadece dizilerde kullanılmaz listelerde kullanılır listede dizilerin dağınık şekli diyebilirz
            //}
            //---------------------------------------------------------------------------------

            //BİR KELİMEYİ HARFLERİNE AYIRMA

            //string word = "mer";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            //---------------------------------------------------------------------------------


            #endregion

            #region Örnek Sınav sistemi Uygulaması

            //klavyeden öğrenci sayısı öğrencilerin isimleri öğrencilerin sınav notlarını ortalamalarını hesaplayan program

            Console.WriteLine("****C# Eğitim Kampı Sınav Uygulaması**** ");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-----------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var? : ");
            int studentcount=int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            //öğrencilerin ortalamalarını ve isimlerini tutan dizileri belirledik. dizilerin eleman sayıları yukarıda girilen öğrenci sayısıdır
            double[]notort=new double[studentcount];
            string[]names=new string[studentcount];

            for(int i=0; i<studentcount; i++)
            {
                Console.Write("öğrenci adını giriniz: ");
                names[i] = Console.ReadLine();

                double totalExamResult = 0;

                //her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{names[i]} isimli öğrencinin {j + 1}. notunu giriniz: ");
                    double value=double.Parse(Console.ReadLine());

                    totalExamResult += value;//öğrencinin 3 sınav notunu topladık
                }
                Console.WriteLine();

                notort[i] = totalExamResult/3;// toplam notu 3 e bölüp bir kişinin not ortalamasının bulduk ve bu değeri notort dizisine atadık

            }

            //sınav ortalamaları
            for (int i = 0; i < studentcount; i++)
            {
                Console.WriteLine($"{names[i]} adlı öğrencinin not ortalaması:" + notort[i]);

                if (notort[i] >= 50)
                {
                    Console.WriteLine($"{names[i]} adlı öğrenci dersten geçti");
                }
                else
                {
                    Console.WriteLine("kaldı dersten otur çalış");
                }
                Console.WriteLine() ;

            }

                #endregion
                Console.Read();
        }
    }
}
