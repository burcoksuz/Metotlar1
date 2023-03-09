using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar8
{
    public class Program
    {

        static float fiyat;


        public static void Menu(int secim)
        {
            if (secim == 1)
            {
                Console.WriteLine("*********Sebze Yemekleri Ekranı*********");
                Console.WriteLine("1-Taze fasulye");
                Console.WriteLine("2-Pırasa yemeği");
                Console.WriteLine(" Yemeğin kodunu tuşlayarak seçiminizi yapınız.");
                int secim2=Convert.ToInt32(Console.ReadLine());

                if (secim2 == 1)
                {
                    fiyat += 40;
                    float tutar=Fis(fiyat);
                    Console.WriteLine("Ödemeniz gereken tutar: "+tutar);
                }
                else if(secim2 == 2)
                {
                    fiyat += 45;
                    float tutar = Fis(fiyat);
                    Console.WriteLine("Ödemeniz gereken tutar: " + tutar);
                }
            }

            if (secim == 2)
            {
                Console.WriteLine("*********Et Yemekleri Ekranı*********");
                Console.WriteLine("1-Karnıyarık");
                Console.WriteLine("2-Et Sote Yemeği");
                Console.WriteLine(" Yemeğin kodunu tuşlayarak seçiminizi yapınız.");
                int secim4 = Convert.ToInt32(Console.ReadLine());

                if(secim4 == 1)
                {
                    fiyat += 70;
                    float tutar = Fis(fiyat);
                    Console.WriteLine("Ödemeniz gerekn tutar: "+tutar);
                }
                else if( secim4 == 2)
                {
                    fiyat += 60;
                    float tutar = Fis(fiyat);
                    Console.WriteLine("Ödemeniz gereken tutar: "+tutar);
                }
            }
        }

        



        public static float Fis(float fiyat)
        {
            Console.WriteLine("********Tatlı Ekranı******");
            Console.WriteLine("Tatlı ister misiniz? \n1-EVET \n2-HAYIR");
            Console.WriteLine("Seçeneklerin kodunu tuşlayarak seçiminizi yapınız.");
            int secim3=Convert.ToInt32(Console.ReadLine()); 

            if(secim3 == 1)
            {
                fiyat += 20;
                return fiyat;
            }
            else if(secim3==2)
            {
                return fiyat;
            }
            else
            {
                return fiyat;
            }
        }




        static void Main(string[] args)
        {
            Console.WriteLine("**********Menü**********");
            Console.WriteLine("1-Sebze Yemekleri");
            Console.WriteLine("2-Et Yemekleri");
            Console.WriteLine("Seçeneklerin kodunu tuşlayarak seçiminizi yapınız.");
            int secim=Convert.ToInt32(Console.ReadLine());
            Menu(secim);

            Console.ReadKey();
        }
        
    }
}
