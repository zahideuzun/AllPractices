namespace VucutKitleEndeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***VÜCUT KİTLE ENDEKSİ***");
            Console.Write("Lütfen boyunuzu m cinsinden (virgül kullanarak) giriniz: ");
            double boy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lütfen kilonuzu kg cinsinden giriniz: ");
            double kilo = Convert.ToDouble(Console.ReadLine());

            //vücut agirliginin boy uzunlugunun karesine bölünmesiyle hesaplanır 
            double hesap = kilo / (boy * boy);
            if (hesap <= 18.49)
            {
                Console.WriteLine("İdeal kilonuzun altındasınınz!!!");
            }
            else if (hesap >= 18.50 && hesap <= 24.99)
            {
                Console.WriteLine("İdeal kilonuzdasınız:)");
            }
            else if (hesap >= 25 && hesap <= 29.99)
            {
                Console.WriteLine("İdeal kilonun üzerindesiniz!!!");
            }
            else if (hesap >= 30)
            {
                Console.WriteLine("İdeal kilonun çok üzerindesiniz!!!!");
            }
            else
            {
                Console.WriteLine("ACİL DOKTORA GÖRÜNMELİSİNİZ!!!!");
            }

            //switch (hesap)
            //{
            //    case (hesap <= 18.49):

            //}
           


        }
    }
}