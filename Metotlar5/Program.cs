using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar5
{
    internal class Program
    {
        /*züccaciye:
         *1- Mutfak Gereçleri:
         *a)Tencere takımı
         *b)yemek takımı
         *
         *2-Oda gereçleri:
         *
         *vergiHesaplama(fiyat,adet) burdan çıkan sonuca %18 kdv uygulayarak değeri döndürcek(returnlu)
         *
         *vergi hesaplamadan gelen son tutara göre voidli bir metot yapılcak(sontutar) vidli
         *tutr eğer 100 ile 1000 arasında ise %10 indirim kazansın+ütü kazansın
         *tutar eğer 1000 ile 7800 arasında ise %15  indirim +airfrey
         *tutar eğer 7800 üzerinde ise %20  indirim + dyson süpürge
         */


        public static float vergiHesap(float fiyat,int adet)
        {
            fiyat *= adet;
            fiyat += fiyat * 0.18f;
            return fiyat;
        }

       
        public static void indirim(float tutar)
        {
            if(tutar<1000 && tutar >= 100)
            {
                tutar -= tutar * 0.10f;
                Console.WriteLine("İndirimli son tutar: " +tutar+" --> Ütü kazandınız.");
            }
            else if(tutar<=7800 && tutar >=1000)
            {
                tutar -= tutar * 0.15f;
                Console.WriteLine("İndirimli son tutar: "+tutar+ " --> AirFryer kazandınız.");
            }
            else if (tutar > 7800)
            {
                tutar -= tutar * 0.20f;
                Console.WriteLine("İndirimli son tutar: "+tutar+" --> Dyson süpürge kazandınız.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*******ZÜCCACİYE*******");
            Console.WriteLine("1-Mutfak gereçleri");
            Console.WriteLine("2-Oda gereçleri");

            int secim=Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.WriteLine("1-Tencere Takımı");
                    Console.WriteLine("2-Yemek Takımı");
                    int secim2=Convert.ToInt32(Console.ReadLine());

                    switch (secim2)
                    {
                        case 1:
                            Console.WriteLine("******Tencere Takımı Ekranı*****");
                            Console.WriteLine("Fiyat giriniz: ");
                            float fiyat=Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine("Adet giriniz:");
                            int adet=Convert.ToInt32(Console.ReadLine());   

                            float tutar=vergiHesap(fiyat,adet);
                            Console.WriteLine("KDV'li Tutar: " + tutar);

                            indirim(tutar);


                            break;

                        case 2:
                            Console.WriteLine("******Yemek Takımı Ekranı*******");
                            Console.WriteLine("Fiyat giriniz: ");
                            fiyat = Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine("Adet giriniz:");
                            adet = Convert.ToInt32(Console.ReadLine());

                            tutar = vergiHesap(fiyat, adet);
                            Console.WriteLine("KDV'li tutar: " + tutar);

                            indirim(tutar);
                            break;
                    }
                    break;



                case 2:

                    break;
            }
            Console.ReadLine();
        }
    }
}
