namespace HaftaninGunleri
{
    internal class Program
    {
        enum Gunler { Pazartesi=1, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar }
        static void Main(string[] args)
        {
            Console.WriteLine("1 ile 7 arasında bir sayı girin: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Seçtiğiniz gün: " + Gunler.Pazartesi);
                    break;
                case "2":
                    Console.WriteLine("Seçtiğiniz gün: " + Gunler.Salı);
                    break;
                case "3":
                    Console.WriteLine("Seçtiğiniz gün: " + Gunler.Çarşamba);
                    break;
                case "4":
                    Console.WriteLine("Seçtiğiniz gün: " + Gunler.Perşembe);
                    break;
                case "5":
                    Console.WriteLine("Seçtiğiniz gün: " + Gunler.Cuma);
                    break;
                case "6":
                    Console.WriteLine("Seçtiğiniz gün: " + Gunler.Cumartesi);
                    break;
                case "7":
                    Console.WriteLine("Seçtiğiniz gün: " + Gunler.Pazar);
                    break;
                default:
                    Console.WriteLine("YANLIŞ GİRİŞ YAPTINIZ!!!");
                    break; 

            }

            

            //if (input == Gunler.Cumartesi || Gunler.Pazar)
            //{
            //    Console.WriteLine("Hafta sonu seçtiniz");
            //}
            //else if 

        }
    }
}