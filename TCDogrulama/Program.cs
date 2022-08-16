Console.Write("TC Kimlik numarası: ");

string kimlikNo = Console.ReadLine();
int kimlikNoLength = 11;

while (kimlikNoLength == (kimlikNo.Length))
{
    if (kimlikNo.StartsWith("0"))
    {
        Console.WriteLine("Hatalı giriş (0) ile başlayamaz!!");
    }
    else
    {
        int[] haneler = new int[kimlikNoLength];
        for (int i = 0; i < haneler.Length; i++)
        {
            haneler[i] = Convert.ToInt32(kimlikNo[i]);
        }
        int tekToplam = haneler[0] + haneler[2] + haneler[4] + haneler[6] + haneler[8];
        int ciftToplam = haneler[1] + haneler[3] + haneler[5] + haneler[7];
        int haneOn = ((tekToplam * 7) - ciftToplam) % 10;

        if (haneOn != haneler[9])
        {
            Console.WriteLine("TC kimlik no doğru değildir!!");
        }
        else
        {
            int sayilarToplam = 0;
            for (int i = 0; i < haneler.Length; i++)
            {
                sayilarToplam += haneler[i];
            }
            int haneOnbir = (sayilarToplam % 10);
            if (haneOnbir == haneler[10])
            {
                Console.WriteLine("Geçerli bir TC girdiniz");
            }
            else
            {
                Console.WriteLine("Geçersiz bir TC girdiniz");
            }


        }


        Console.WriteLine("TC Kimlik numarası: ");
    }
}
