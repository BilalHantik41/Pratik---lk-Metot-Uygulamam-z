using System;


namespace Metodlar
{
    class Program
    {
        public static void Main()
        {
            sarkiSözleri();
            rastgeleTamsayi();
            
            
            
            Console.Write("Birinci sayiyi girin: ");
            int a = int.Parse(Console.ReadLine()!);

            Console.Write("İkinci sayiyi girin: ");
            int b = int.Parse(Console.ReadLine()!);

            int carpimSonucu = carpimYapanMetod(a, b);
            Console.WriteLine($"{a} × {b} = {carpimSonucu}");

            
            Console.WriteLine("Bir ad Giriniz: ");
            string ad = Console.ReadLine();
            Console.WriteLine("Bir Soyad Giriniz: ");
            string soyAd = Console.ReadLine();
            SelamVer(ad,soyAd);
            
        }

        public static void sarkiSözleri()
        {   Console.WriteLine("--------------------------");
            Console.WriteLine("Kasette Simge'den Aşkin olayim çaliyor.");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Aşkiiin olayiiim");
            Console.WriteLine("--------------------------");
        }
        
        public static void rastgeleTamsayi()
        {
        Console.WriteLine("Rastgele Bir Tam Sayi Oluşturuyoruz 1-100 arasinda");
        Console.WriteLine("--------------------------");
        Random rnd = new Random();
        // 1 ile 100 arasında tamsayı
        int sayi = rnd.Next(1, 101);
        Console.WriteLine("Rastgele tamsayi (1-100): " + sayi);
        Console.WriteLine("--------------------------");
        }

        public static int carpimYapanMetod(int a,int b)
        {
            
            return (a*b);
        }
        
        public static void SelamVer(string ad,string soyAd)
        {
            Console.WriteLine("Hoş Geldiniz" +" "+ ad +" "+ soyAd );
        }

    }    
}