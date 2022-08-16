namespace OrtalamaHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ORTALAMA HESAPLAMA");
            Console.WriteLine("Lütfen ortalama hesaplamak için sayı giriniz. Çıkış için 'q' ya basın!");
            Console.Write("Sayı: ");
            string giris = Console.ReadLine();
            double sayi;
            double toplam = 0;
            double adet = 0;
            double ortalama; 
            while(giris != "q")
            {
                sayi = Convert.ToDouble(giris);
                toplam += sayi;
                adet++;
                Console.WriteLine("Toplam: " + toplam + " adet: " + adet );
                Console.Write("Sayı: ");
                giris = Console.ReadLine();
            }
            if (adet > 1)
            {
                ortalama = toplam / adet; 
                Console.WriteLine("Girdiğiniz sayıların ortalaması: " + ortalama);
            }
            else
            {
                Console.WriteLine("Lütfen birden fazla sayı giriniz!!!!");
            }

        }
    }
}