namespace FaktoriyelSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayi giriniz: ");
            double sayi = Convert.ToDouble(Console.ReadLine());
            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }
            Console.WriteLine(sayi + "! = " + faktoriyel);

            Console.ReadLine();
        }
    }
}