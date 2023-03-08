using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar4
{
    internal class Program
    {
        //1-Kara yolları
        //2-Hava yolları
        //3-Demir yolları

        //Ana menü:

        //Hepsinin ortak metotu:
        //fiyat giriniz,adet giriniz returnlu 2 parametreli tutar hesaplama metotu.
        //Void kullanıcı bilgilerini alan ekran yazdıran bilgi. parametresiz

        public static float Tutar(float fiyat,int adet)
        {
            fiyat *= adet;
            return fiyat;   
        }

        public static void Info()
        {
            Console.WriteLine("Adınızı ve Soyadınızı giriniz: ");
            string adSoyad =Console.ReadLine();
            Console.WriteLine("Yaşınızı giriniz: ");
            int yas=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("TC kimlik numaranızı giriniz:");
            string TC=Console.ReadLine(); //long TC=Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Ad Soyad: " + adSoyad);
            Console.WriteLine("Yaş: "+yas);
            Console.WriteLine("TC: "+TC);


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ulaşım yolunu seçiniz: ");
            Console.WriteLine("1-Kara Yolları");
            Console.WriteLine("2-Hava Yolları");
            Console.WriteLine("3-Demir Yolları");

            int secim=Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.WriteLine("Fiyat giriniz:");
                    float fiyat = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Adet giriniz:");
                    int adet = Convert.ToInt32(Console.ReadLine());

                    Info(); 

                    float sonuc = Tutar(fiyat, adet);
                    Console.WriteLine("Tutar: "+sonuc);
                    break;


                case 2:
                    Console.WriteLine("Fiyat giriniz:");
                    fiyat = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Adet giriniz:");
                    adet = Convert.ToInt32(Console.ReadLine());

                    Info();

                    sonuc = Tutar(fiyat, adet);
                    Console.WriteLine("Tutar: " + sonuc);    
                    break;


                case 3:
                    Console.WriteLine("Fiyat giriniz:");
                    fiyat = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Adet giriniz:");
                    adet = Convert.ToInt32(Console.ReadLine());

                    Info();

                    sonuc = Tutar(fiyat, adet);
                    Console.WriteLine("Tutar: " + sonuc);          
                    break;


            }
            Console.ReadLine();
        }
    }
}
