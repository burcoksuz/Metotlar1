using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar2
{
    internal class Program
    {

        //Main metotu herkesi çalıştırır. ama başka metotlar onu çalıştıramaz!

        public static float Zam(float fiyat, float oran) //Geriye değer döndüren parametreli metot.
        {
            fiyat += fiyat * oran / 100;
            return fiyat;
        }



        public static float indirim(float fiyat,float oran)
        {
            if (fiyat < 100)
            {
                fiyat -= fiyat * oran / 100;
                fiyat -= 10;
                return fiyat;
            }
            else
            {
                return fiyat -50; //fiyatı 50 tl eksilt.
            }
        }


        public static void Ozellik(string urunAd, float fiyat)
        {
            if(urunAd=="bardak" || urunAd == "termos")
            {
                Console.WriteLine("Bardak ve sürahide indirim var faydalanın");
            }
            else
            {
                Console.WriteLine("Diğer ürünlerde ekstra indirim var.");
                Console.WriteLine("fiş tutarı üzerindn 100 tl indirim uygulanacak.");

                fiyat -= 100;

                Console.WriteLine("Son tutarınız: " +fiyat);
            }

            Console.WriteLine("Kampanyaya katılmak ister misiniz?");
            string deger=Console.ReadLine();

            if (deger == "evet")
            {
                int hediyeCeki = 1;
                Console.WriteLine("bir dahaki alışverişte "+ hediyeCeki+" kadar bonus para kazandınız.");
            }
            else
            {
                Console.WriteLine("Bye güzelim.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1-Bardak");
            Console.WriteLine("2-Sürahi");
            Console.WriteLine("3-Termos");
            Console.WriteLine("Ürün seçiniz:");
            string urun = Console.ReadLine(); 

            switch (urun)
            {
                case "bardak":
                    //zam
                    //void metot direk yazılır. Zam();
                    //returnlu olan metotları ya döndürdüğü değişken değerine atarım ya da cv içinde yazarak çağırabilirm.

                    Console.WriteLine("fiyat giriniz:");
                    float fiyat=Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("oran giriniz:");
                    float oran=Convert.ToSingle(Console.ReadLine());

                    //return metot çağırma 1:
                    float sonuc=Zam(fiyat, oran);
                    Console.WriteLine("Ödemeniz gereken tutar: " +sonuc);

                    Ozellik(urun, fiyat);


                    break;

                case "sürahi":
                    //indirim

                    Console.WriteLine("fiyat giriniz: ");
                    fiyat=Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("oran giriniz: ");
                    oran=Convert.ToSingle(Console.ReadLine());  
                    float tutar=indirim(fiyat,oran);

                    Console.WriteLine("ödemeniz gereken indirimli tutar: " +tutar);

                    Ozellik(urun, fiyat);

                    break;

                case "termos":
                    Console.WriteLine("fiyat giriniz:");
                    float fiyat2 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("oran giriniz:");
                    float oran2 = Convert.ToSingle(Console.ReadLine());

                    //return metot çağırma 2:

                    Console.WriteLine("Ödemeniz gereken tutar: " +Zam(fiyat2,oran2));


                    Ozellik(urun,fiyat2); //kullanıcıdan alınan. //Ozellik("bardak",250): sabit parametre


                    break;
                    

            }
            Console.ReadKey();
        }
    }
}
