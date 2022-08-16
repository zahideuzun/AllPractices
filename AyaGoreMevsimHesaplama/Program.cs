namespace AyaGoreMevsimHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Aya Göre Hangi Mevsim ***");
            Console.Write("Sayısal olarak ay giriniz (1 - 12): ");
            int ay = Convert.ToInt32(Console.ReadLine());
            if (ay == 0) // 0 girildiginde hata verip uygulamadan atsin 
            {
                Console.WriteLine("Yanlış giriş yaptınız! 1-12 aralığında bir sayı giriniz!");
                    return;
            }
            if (ay == 12)
            {
                ay = 0;
            }
            else if (ay >= 0 && ay <= 2)
            {
                Console.WriteLine("KIŞ MEVSİMİ");
            }
            else if (ay >= 3 && ay <= 5)
            {
                Console.WriteLine("İLKBAHAR MEVSİMİ");
            }
            else if (ay >= 6 && ay <= 8)
            {
                Console.WriteLine("YAZ MEVSİMİ");
            }
            else if (ay >= 9 && ay <= 11)
            {
                Console.WriteLine("SONBAHAR MEVSİMİ");
            }
            else
            {
                Console.WriteLine("1-12 aralığında bir ay giriniz!!!!!");
            }

        }
    }
}

enum Aylar
{
    Ocak = 1,
    Şubat = 2,
    Mart = 3,
    Nisan = 4,
    Mayıs = 5,
    Haziran = 6,
    Temmuz = 7,
    Ağustos = 8,
    Eylül = 9,
    Ekim = 10,
    Kasım = 11,
    Aralık= 12
}
