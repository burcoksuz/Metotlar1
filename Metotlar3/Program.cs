using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar3
{
    internal class Program
    {
        //Dışarıdan girilen değerin karesini bulan program(returnlu 1 parametreli)

        public static int sayiKare(int sayi)
        {
            sayi *= sayi;
            return sayi;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi=Convert.ToInt32(Console.ReadLine());

            int sonuc=sayiKare(sayi);
            Console.WriteLine("Giridiğiniz sayının karesi: "+sonuc);

            Console.ReadKey();
        }
       
    }
}
