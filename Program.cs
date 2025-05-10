using System;


namespace Metodlar
{
    class Program
    {
        public static void Main()
        {
            sarkiSözleri();
            rastgeleTamsayi();
            
            
            Console.WriteLine(rastgeleTamsayi());
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
        {   
            Console.WriteLine("Kasette Simge'den Aşkin olayim çaliyor.");
            
            Console.WriteLine("Aşkiiin olayiiim");
            
        }
        
        public static int rastgeleTamsayi()
        {
            
            
            
            int sayi=new Random().Next();
            
            return sayi%2;
            
            
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