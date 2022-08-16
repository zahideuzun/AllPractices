namespace PalindromSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kelime giriniz");
            string deger = Console.ReadLine();
            string degerters = "";

            while (deger != "q")
            {
                degerters = "";
                if (deger.Length < 3)
                {
                    Console.WriteLine("HATALI GİRİŞ!!");
                }
                else
                {
                    for (int i = deger.Length - 1; i >= 0; i--)
                    {
                        degerters += deger[i];
                    }
                    if (deger == degerters)
                        Console.WriteLine("Palindrom kelime!");
                    else
                        Console.WriteLine("Palindrom kelime değildir!");
                }
                Console.WriteLine("Bir kelime giriniz");
                deger = Console.ReadLine();
            }
        }

    }
}