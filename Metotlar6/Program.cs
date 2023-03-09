using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar6
{
    internal class Program
    { 
        //HERYERDEN ERİŞİLEBİLEN DEĞİŞKEN TİPİ TANIMLA 
        static int fiyat;

        public static void AnaMenu(int secim)
        {
            if (secim == 1)
            {
                Console.WriteLine("m-Mercimek Çorbası");
                Console.WriteLine("t-Tarhana Çorbası");
                char corba = Convert.ToChar(Console.ReadLine());
                if (corba == 'm' || corba == 'M')
                {
                    fiyat += 30;
                    int sontutar = fis(fiyat);
                    Console.WriteLine("ödemeniz gereken tutar : " + sontutar);
                }
                else
                {
                    fiyat += 35;
                    int sontutar = fis(fiyat);
                    Console.WriteLine("ödemeniz gereken tutar : " + sontutar);
                }
            }


        }

        //fiyat patametresi corba veya sebzeden gelen deger olucaktır.
        public static int fis(int fiyat)
        {
            Console.WriteLine("içecek istermisiniz");
            string cevap = Console.ReadLine();
            if (cevap == "evet")
            {
                fiyat += 20;
                return fiyat;
            }
            else
            {
                return fiyat;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1-Çorba");
            Console.WriteLine("2-Sebze yemekleri");
            int secim = Convert.ToInt32(Console.ReadLine());
            AnaMenu(secim);
            Console.ReadLine();
        }
    }
}
