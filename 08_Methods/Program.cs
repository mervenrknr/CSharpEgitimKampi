using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region VOİD Methotlar
            //hazır methotlar string int gibi yapılardır
            //kendi methotlarımı oluşturucaz bunlar içinde bazı sözdizimi kurallar var
            //bir yapının method olduğunu anlamak için sonuna () işareti olması gerekir
            //methotlar ikiye ayrılı bunlardan birincisi GERİYE DEĞER DÖNDÜRMEYEN METOTLAR
            //listeleme ekle sil güncelle gibi işlemlerde bir değişiklik yapıldığında yeniden methodu çağırabilirsin
            //geri değer döndürmeyen metotlara void metotlar denir

            //void CustomerList()//metotu oluşturduk içindekileride belirledik
            //{
            //    Console.WriteLine("ali yıldız");
            //    Console.WriteLine("ayşe yıldız");
            //    Console.WriteLine("fatma kara");
            //    Console.WriteLine("sinem duran");
            //}

            //CustomerList();

            //buradaki satırı yazmamın sebebi metotu çağırmam içindi
            //özellikle geriye değer döndürmeyen metotlar belli işlemleri tekrar etmesinden kurtarmak içinde programlamada önemli bir yere sahiptirler


            #endregion

            #region Geriye değer döndürmeyen string parametli metotlar
            //void writemetot(string adiniz)
            //{ 
            //    Console.WriteLine(adiniz);

            //}
            //writemetot("merve");



            //void CustomerCard(string name,string surname) {
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerCard("merve", "kenar");
            //CustomerCard("sümeyye", "kenar");


            #endregion

            #region Geriye değer döndrmeyen int parametli metotlar

            // void topla(int sayi1,int sayi2,int sayi3)
            //{
            //    Console.WriteLine("işlem sonucu: " + (sayi1 + sayi2 + sayi3));
            //}

            //topla(5, 8, 6);
            #endregion

            #region geriye değer döndüren metotlar

            //string customerName()
            //{
            //    return "merve";

            //}
            //customerName(); //>> çıktı boştur  karşılıpı yoktur returnda yazdırıyıoz çünkü

            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surname = "kaya";
            //    return name+ " " + surname; //yazdırma işlemini metodun dışında yaptırabilirim
            //}
            //Console.WriteLine(studentCard());



            #endregion

            #region Geriye değer döndüren stringpareöetreli metotlar
            //string countryCard(string countryname,string capital,string flagColor)
            //{
            //    string cardinfo = "ülke: " + countryname + " " + "Başkent: " + capital + " " + "Bayrak rengi: " + flagColor;
            //    return cardinfo;
            //}

            //string x, y,z;
            //Console.WriteLine("ülke adını giriniz: ");
            //x= Console.ReadLine();
            //Console.WriteLine("Başkenti giriniz: ");
            // y= Console.ReadLine();
            //Console.WriteLine("bayrak rengini giriniz: ");
            //z= Console.ReadLine();

            //Console.WriteLine(countryCard(x,y,z));

            #endregion

            #region geriye değer döndüren int paremetleri metotlar

            //int sum(int number1, int number2)
            //{
            //    int result=number1 + number2;
            //    return result;
            //}

            //Console.Write("ilk sayıyı giriniz: ");
            //int x= Convert.ToInt32(Console.ReadLine());
            //Console.Write("ikinci sayıyı giriniz: ");
            //int y= Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("toplama işleminin sonucu: "+sum(x, y));


            #endregion

            #region Örnek uygulama

            string examResult(string student,int exam1, int exam2, int exam3)
            {
                int result=(exam1+exam2+exam3)/3;
                Console.WriteLine(result);
                if (result >= 50)
                {
                    return student+" isimli öğrenci sınavı geçti"; 
                }
                else
                {
                    return "öğrenci başarısız oldu";
                }
               
            }
            Console.WriteLine(examResult("ali",25,41,50));
            Console.WriteLine(examResult("merve",85,51,50));
            #endregion


            Console.ReadKey();
        }
    }
}
