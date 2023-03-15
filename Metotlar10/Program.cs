using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar10
{
   
    internal class Program
    {
        
        public static void Ayakkabi(int secim)
        {       Console.WriteLine("*******Ayakkabı Ekranı*******");
                Console.WriteLine("Ürün Çeşidi giriniz.");
                Console.WriteLine("1-Yazlık Ayakkabı");
                Console.WriteLine("2-Kışlık Ayakkabı");
                int secim2=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Fiyat Bilgisini giriniz:");
                float fiyat=Convert.ToSingle(Console.ReadLine());

            if (secim2 == 1)
            {
                fiyat -= fiyat * 20 / 100;
                Console.WriteLine("%20 indirimli fiyat:" +fiyat);
                float sonTutar = Uyelik(fiyat);
                Console.WriteLine("Ödenmenmesi gereken son tutar: "+sonTutar);
                float ekstraliTutar = Aksesuar(fiyat);
                Console.WriteLine("Ödenmesi gereken ekstralı tutar:"+ekstraliTutar);

            }
            else if(secim2 == 2)
            {
                Console.WriteLine("Kışlık ayakkabı indirimsiz fiyat:" +fiyat);
                float sonTutar = Uyelik(fiyat);
                Console.WriteLine("Ödenmenmesi gereken son tutar: " + sonTutar);
                float ekstraliTutar = Aksesuar(fiyat);
                Console.WriteLine("Ödenmesi gereken ekstralı tutar:" + ekstraliTutar);
            }
            
        }

        public static void DisGiyim(int secim)
        {
            Console.WriteLine("*******Dış Giyim Ekranı*******");
            Console.WriteLine("Ürün Çeşidi giriniz.");
            Console.WriteLine("1-Pantolon");
            Console.WriteLine("2-Mont");
            int secim3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fiyat Bilgisini giriniz:");
            float fiyat = Convert.ToSingle(Console.ReadLine());

            if(secim3== 1)
            {
                fiyat -= fiyat * 15 / 100;
                Console.WriteLine("%15 indirimli fiyat:" + fiyat);
                float sonTutar = Uyelik(fiyat);
                Console.WriteLine("Ödenmenmesi gereken son tutar: " + sonTutar);
                float ekstraliTutar = Aksesuar(fiyat);
                Console.WriteLine("Ödenmesi gereken ekstralı tutar:" + ekstraliTutar);
            }
            else if (secim3 == 2)
            {
                fiyat -= fiyat * 30 / 100;
                Console.WriteLine("%30 indirimli fiyat:" + fiyat);
                float sonTutar = Uyelik(fiyat);
                Console.WriteLine("Ödenmenmesi gereken son tutar: " + sonTutar);
                float ekstraliTutar = Aksesuar(fiyat);
                Console.WriteLine("Ödenmesi gereken ekstralı tutar:" + ekstraliTutar);
            }


        }


        public static float Uyelik(float fiyat)
        {
            Console.WriteLine("Üyeliğiniz var mı?");
            Console.WriteLine("1-Evet");
            Console.WriteLine("2-Hayır");

            int secim4=Convert.ToInt32(Console.ReadLine()); 

            if(secim4 == 1)
            {
                fiyat -= fiyat / 2;
                return fiyat;
            }
            else
            {
                return fiyat;
            }
        }


        public static float Aksesuar(float fiyat)
        {
            Console.WriteLine("Aksesuar ister misin?");
            Console.WriteLine("1-Evet");
            Console.WriteLine("1-Hayır");
            int secim5=Convert.ToInt32(Console.ReadLine());

            if( secim5 == 1)
            {
                Console.WriteLine("Adet giriniz:");
                int adet=Convert.ToInt32(Console.ReadLine());

                fiyat += 780 * adet;
                return fiyat;
            }
            else
            {
                return fiyat;
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("*******Ana Ekran*******");

           
            Console.WriteLine("1-Erkek Giyim");
            Console.WriteLine("2-Kadın Giyim");
            int cinsiyet = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("1-Ayakkabı");
            Console.WriteLine("2-Dış giyim");
            Console.WriteLine("3-İç Giyim");

            int secim=Convert.ToInt32(Console.ReadLine());
            if( secim== 1)
            {
                Ayakkabi(secim);
            }
            else if(secim== 2)
            {

            }
            else if (secim == 3)
            {

            }

            Console.ReadKey();

        }
        
    }
}
