using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar7_3
{
    internal class Program
    {

        /*Örnek: 1-Standart Oda
        *        2-Kraliyet Odası
        * her seçenekte gün sayısı ve fiyat istensin.toplam tutarı yazdırın(TutarHesapla)
        * ekstra adında bir metot tanımla yemek parası eğlence parası gibi sorulara göre fiyata ücret ekle. 10000
        * vergi method tutarhesaptan gelen parametre ile vergi hesaplatılacak 
        * gün sayısı eğer 10 dan az ise fiyat+%12,5 yeni fiyat üzerinden kdv+%7,5 eklicek ve son tutarı yansıtıcak.
        * gün sayısı eğer 10dan fazla ise fiyat+%15 kdv+%12,5 eklicek ve son tutarı yansıtıcak.
        */
        //kraliyet odasında ise tutarhesaplama methodu yapılıcak
        //ve kullanıcıya ekstra özellikleri görmek istermisiniz?
        //evet derse eger şu secenkleri sun 
        //s-SAUNA
        //J-jAKUZİ
        //H-HEPSİ 
        //EGER S SECERSE TUTARHESAPLAMADAN DÖNEN TUTARA 4500 EKLE 
        //EGER J SECERSE TUTARHESAPLAMADAN DÖNEN TUTARA 5500 EKLE 
        //EGER H SECERSE TUTARHESAPLAMADAN DÖNEN TUTARA 7500 EKLE

        public static void AnaMenu(int secim)
        {
            if (secim == 1)
            {
                Console.WriteLine("gün sayısı giriniz");
                int gun = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("oda fiyat giriniz");
                int fiyat = Convert.ToInt32(Console.ReadLine());
                int sonuc = Tutarhesaplama(fiyat, gun);
                int toplamfiyat = ekstra(sonuc);
                vergi(toplamfiyat, gun);

            }
            else if(secim == 2)
            {
                Console.WriteLine("gün sayısı giriniz");
                int gun = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("oda fiyat giriniz");
                int fiyat = Convert.ToInt32(Console.ReadLine());
                int sonuc = Tutarhesaplama(fiyat, gun);
                ekstraOzellik(sonuc);
            }
        }

        public static int Tutarhesaplama(int fiyat, int gun)
        {
            fiyat *= gun;
            return fiyat;
        }

        public static int ekstra(int fiyat)
        {
            Console.WriteLine("ekrsta secenk sec <yemek ise y /eglence e/hepsi h> bas");
            string secenek = Console.ReadLine();
            if (secenek == "y")
            {
                fiyat += 1000;
                return fiyat;
            }
            else
            {
                fiyat += 2000;
                return fiyat;
            }
        }

        public static void vergi(int fiyat, int gun)
        {
            if (gun < 10)
            {
                fiyat += (fiyat * 12 / 100) + (fiyat * 7 / 100);
                Console.WriteLine("vergili son tutar : " + fiyat);
            }
            else
            {
                fiyat += (fiyat * 15 / 100) + (fiyat * 12 / 100);
                Console.WriteLine("vergili son tutar : " + fiyat);
            }
        }


        public static void ekstraOzellik(int fiyat)
        {
            Console.WriteLine("Ekstra Özellikleri görmek ister misiniz?");
            Console.WriteLine("1-Evet \n1-Hayır");
            int ozellikSec=Convert.ToInt32(Console.ReadLine());
            if(ozellikSec == 1)
            {
                Console.WriteLine("1-Sauna");
                Console.WriteLine("2-Jakuzi");
                Console.WriteLine("3-Hepsi");
                int ozellikSec2=Convert.ToInt32(Console.ReadLine());

                if(ozellikSec2 == 1)
                {
                    fiyat += 4500;
                    Console.WriteLine("Saunalı fiyat: "+fiyat);
                }
                else if (ozellikSec2 == 2)
                {
                    fiyat += 5500;
                    Console.WriteLine("Jakuzili fiyat: " + fiyat);
                }
                else if(ozellikSec2 == 3)
                {
                    fiyat += 7500;
                    Console.WriteLine("Hepsi dahil fiyat: " + fiyat);
                }
                
            }
            else if (ozellikSec == 2)
            {
                Console.WriteLine("Ödenmesi gereken fiyat: "+fiyat);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("1-standart oda");
            Console.WriteLine("2-kraliyet odası");
            int secim = Convert.ToInt32(Console.ReadLine());
            AnaMenu(secim);
            Console.ReadLine();
        }
    }
}
