using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar7
{
    internal class Program
    {

        //  BENİM YAPTIĞIM:


        /*Main kısmı:
             * 1-Standart Oda
             * 2-Kraliyet Odası
             * her seçenekte gün sayısı ve fiyat istensin. toplam tutarı yazdırın (TutarHesapla)
             * ekstra adında bir metot tanımla yemek parası eğlence parası gibi sorulara göre fiyata ücret ekle. 10000
             * vergi method tutarhesaptan gelen parametre ile vergi hesaplatılacak 
             * gün sayısı eğer 10 dan az ise fiyat+%12,5 kdv+%7,5 eklicek ve son tutarı yansıtıcak.
             * gün sayısı eğer 10dan fazla ise  fiyat+%15 kdv+%12,5 eklicek ve son tutarı yansıtıcak.
             */

        static float fiyat;
        static int gun;
        static float ekstra;
        
        public static float TutarHesapla(float fiyat, int gun)
        {
            fiyat = fiyat * gun;
            return fiyat;
        }




        public static float Ekstra(float fiyat,int gun)
        {
            Console.WriteLine("********Ekstra Ekranı*******");
            Console.WriteLine("Yemek paketi ister misiniz? \n1-EVET \n2-HAYIR");
            int secim2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eğlence paketi ister misiniz? \n1-EVET \n2-HAYIR");
            int secim3=Convert.ToInt32(Console.ReadLine());
            if (secim2 == 1 && secim3==1)
            {
                float ekstra = TutarHesapla(fiyat, gun);
                ekstra += 200 * gun;
                return ekstra;
                
            }
            else if(secim2 == 1 && secim3 == 2)
            {
                float ekstra = TutarHesapla(fiyat, gun);
                ekstra += 90 * gun;
                return ekstra;
            }
            else if( secim2 == 2 && secim3 == 1)
            {
                float ekstra = TutarHesapla(fiyat, gun);
                ekstra += 110 * gun;
                return ekstra;
            }
            else
            {
                float ekstra = TutarHesapla(fiyat, gun);
                return ekstra;
            }
        }




        public static void Vergi(float fiyat,int gun)
        {
            Console.WriteLine("*******Vergi Ekranı*****");
           

            if (gun < 10)
            {
                Ekstra(fiyat,gun);
                ekstraliFiyat += ekstraliFiyat * 20f / 100f;
                Console.WriteLine("Ödenmesi gereken son tutar: "+ekstraliFiyat);
                
            }
            else if(gun > 10)
            {
                ekstraliFiyat += ekstraliFiyat * 27.5f / 100f;
                Console.WriteLine("Ödenmesi gereken son tutar: " + ekstraliFiyat);
            }


        }

      

        static void Main(string[] args)
        {
            Console.WriteLine("1-Standart Oda");
            Console.WriteLine("2-Kraliyet Odası");
            int secim=Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                Console.WriteLine("Fiyat giriniz:");
                float fiyat = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Gün sayısı giriniz:");
                int gun = Convert.ToInt32(Console.ReadLine());

                float tutar = TutarHesapla(fiyat,gun);
                Console.WriteLine("Tutar: "+tutar);
                float ekstraliTutar = Ekstra(fiyat, gun);
                Console.WriteLine("Ekstralı Tutar: "+ekstraliTutar);
                Vergi(fiyat, gun);


            }
            else if(secim == 2)
            {
                Console.WriteLine("Fiyat giriniz:");
                float fiyat = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Gün sayısı giriniz:");
                int gun = Convert.ToInt32(Console.ReadLine());

                float tutar = TutarHesapla(fiyat, gun);
                Console.WriteLine("Tutar: " + tutar);
            }

            Console.ReadLine();
        }
    }
}
