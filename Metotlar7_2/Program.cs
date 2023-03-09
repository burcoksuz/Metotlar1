using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar7_2
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

        //HER YERDEN ERİŞİLEBİLEN DEĞİŞKEN TİPİ TANIMLAMA:
        static float fiyat;
        static int ekstraSecim;
        static int odaSecim;


        public static void TutarHesapla(int secim)
        {
            if (secim == 1)
            {
                Console.WriteLine("**STANDART ODA**");
                Console.WriteLine("Odanın fiyatını girin");
                fiyat = Convert.ToSingle(Console.ReadLine());


                Console.WriteLine("Kaç gün kalmayı planlıyorsunuz?");
                int gunSayisi = Convert.ToInt32(Console.ReadLine());

                fiyat *= gunSayisi;



                if (gunSayisi < 10)
                {
                    Console.WriteLine("Ekstra paket ister misiniz? İstediğiniz paketi seçiniz.");
                    Console.WriteLine("1-Eğlence");
                    Console.WriteLine("2-Yemek");
                    Console.WriteLine("3-İstemiyorum");
                    ekstraSecim = Convert.ToInt32(Console.ReadLine());

                    Ekstralar(ekstraSecim); //Metot Çağırılıyor...

                    fiyat += fiyat * 0.125f;
                    fiyat += fiyat * 0.075f;
                    Console.WriteLine("Ödemeniz gereken tutar: " + fiyat);
                }
                else
                {
                    Console.WriteLine("Ekstra paket ister misiniz? İstediğiniz paketi seçiniz.");
                    Console.WriteLine("1-Eğlence");
                    Console.WriteLine("2-Yemek");
                    Console.WriteLine("3-İstemiyorum");
                    ekstraSecim = Convert.ToInt32(Console.ReadLine());
                    Ekstralar(ekstraSecim);
                    fiyat += fiyat * 0.15f;
                    fiyat += fiyat * 0.125f;
                    Console.WriteLine("Ödemeniz gereken tutar: " + fiyat);
                }

            }
        }

        public static void Ekstralar(int ekstraSecim)
        {


            switch (ekstraSecim)
            {
                case 1:
                    fiyat += 1000;
                    break;
                case 2:
                    fiyat += 1500;
                    break;
                case 3:
                    break;
            }
            Console.WriteLine("Ekstralarla ödemeniz gereken toplam tutar: " + fiyat);
        }

        static void Main(string[] args)  //İlk Kısım
        {
            Console.WriteLine("Nasıl bir odada kalmak istiyorsunuz?");
            Console.WriteLine("1-Standart Oda");
            Console.WriteLine("1-Kraliyet Odası");
            odaSecim = Convert.ToInt32(Console.ReadLine());

            TutarHesapla(odaSecim); //metot çağırılıyor.

            Console.ReadLine();
        }
    }

}

