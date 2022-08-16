using System.Text.RegularExpressions;

namespace TcNoDogrulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TC Kimlik numaraları 11 basamaktan oluşmaktadır. İlk 9 basamak arasında kurulan
            //bir algoritma bize 10.basmağı, ilk 10 basamak arasında kurulan algoritma ise
            //bize 11.basamağı verir.
            //11 hanelidir.
            //Her hanesi rakamsal değer içerir.
            //İlk hane 0 olamaz.
            //1. 3. 5. 7.ve 9.hanelerin toplamının 7 katından, 2. 4. 6.ve 8.hanelerin toplamı
            //çıkartıldığında, elde edilen sonucun 10′a bölümünden kalan, yani Mod10′u
            //bize 10.haneyi verir.
            //1. 2. 3. 4. 5. 6. 7. 8. 9.ve 10.hanelerin toplamından elde edilen sonucun
            //10′a bölümünden kalan, yani 37516136800 Mod10′u bize 11.haneyi verir.
            //69229062084
            //6+2+9+6+0 =23  * 7  =161
            // 13 
            while (true)
            {
                Console.Write("TC Kimlik numarası: ");
                string kimlikNo = Console.ReadLine();
                int kimlikNoLength = 11;

                if (kimlikNo.StartsWith("0")  )
                {
                    Console.WriteLine("Hatalı giriş (0) ile başlayamaz!!");
                 
                }
                if (!regexControl(kimlikNo))
                {
                    Console.WriteLine("Hatalı giriş, sayı giriniz!!");
                }
                else
                {
                    int[] kimlikNoHane = new int[kimlikNoLength];
                    for (int i = 0; i <= kimlikNoHane.Length-1; i++)
                    {
                        kimlikNoHane[i] = Convert.ToInt32(kimlikNo[i].ToString());
                    }
                    int tekToplam = kimlikNoHane[0] + kimlikNoHane[2] + kimlikNoHane[4] + kimlikNoHane[6] + kimlikNoHane[8];
                    int ciftToplam = kimlikNoHane[1] + kimlikNoHane[3] + kimlikNoHane[5] + kimlikNoHane[7];
                    int haneOn = ((tekToplam * 7) - ciftToplam) % 10;

                    if (haneOn != kimlikNoHane[9])
                    {
                        Console.WriteLine("TC kimlik no doğru değildir!!");
                     
                    }
                    else
                    {
                        int sayilarToplam = 0;
                        for (int i = 0; i <= kimlikNoHane.Length-2; i++)
                        {
                            sayilarToplam += kimlikNoHane[i];
                        }
                        int haneOnbir = (sayilarToplam % 10);

                        if (haneOnbir == kimlikNoHane[10])
                        {
                            Console.WriteLine("Geçerli bir TC girdiniz");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz bir TC girdiniz");
                        }
                    }

                }
            }
            Console.ReadLine();
        }
        private static bool regexControl(string str)
        {
            bool valid = false;

            Regex reg = new Regex("^[0-9]+$");

            if (reg.Match(str).Success)
                valid = true;
            else
                valid = false;

            return valid;
        }
    }





    //int tekToplam = Convert.ToInt32(kimlikNoHane[0]+ kimlikNoHane[2]+
    //kimlikNoHane[4]+ kimlikNoHane[6]+ kimlikNoHane[8])
    //int ciftToplam = Convert.ToInt32(kimlikNoHane[1]+ kimlikNoHane[3]+
    //kimlikNoHane[5]+ kimlikNoHane[7])      
}


