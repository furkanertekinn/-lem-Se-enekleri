using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kararyapisialistirma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menü");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkartma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");
            Console.Write("Seçiniz : ");
            string kullaniciSecim = Console.ReadLine();

            double sayi1 = 0;
            double sayi2 = 0;

            if (kullaniciSecim == "1" || kullaniciSecim == "2" || kullaniciSecim == "3" || kullaniciSecim == "4")
            {
                Console.Write("Sayı 1 Değerini Giriniz : ");
                string sStr1 = Console.ReadLine();

                Console.Write("Sayı 2 Değerini Giriniz : ");
                string sStr2 = Console.ReadLine();


                sayi1 = Convert.ToDouble(sStr1);
                sayi2 = Convert.ToDouble(sStr2);

            }


            if (kullaniciSecim == "1")
            {
                double toplam = sayi1 + sayi2;
                Console.WriteLine("Toplam : " + toplam);
            }

            else if (kullaniciSecim == "2")
            {
                double cikartma = sayi1 - sayi2;
                Console.WriteLine("Çıkartma : " + cikartma);
            }

            else if (kullaniciSecim == "3")
            {
                double carpma = sayi1 * sayi2;
                Console.WriteLine("Çarpma : " + carpma);
            }

            else if (kullaniciSecim == "4")
            {
                if (sayi2 == 0)
                {
                    Console.WriteLine("Bölen değer sıfır olamaz!");
                }

                else
                {
                    double bolum = sayi1 / sayi2;
                    Console.WriteLine("Bölüm : " + bolum);
                }
            }

            else
            {
                Console.WriteLine("Seçim dışı değer girişi yaptınız..");

            }

            Console.WriteLine("Uygulama sonuna gelindi...");
            Console.ReadLine();


        }
    }
}
