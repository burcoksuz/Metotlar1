using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar1
{
    internal class Program
    {
        //metot tanımla
        //parametresiz geriy deger döndürmeyen metot
        public static void Topla(int sayi, int sayi2)
        {
            int toplam = sayi + sayi2;
            Console.WriteLine("toplam sonucu  : " + toplam);

        }

        public static void Carp(int a, int b)
        {
            int carp = a * b;
            Console.WriteLine("Çarpım sonucu : " + carp);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1. sayıyı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("metot başlıyor");
            Topla(sayi, sayi2);
            Console.WriteLine("metot bitti by ");
            Console.WriteLine("çarp metotu çalışıyor");
            Carp(100, sayi2);
            Console.WriteLine("çarp metotu çalıştı. byby");
            Console.ReadLine();
        }
    }
}
