//Console.Write("Doğum yılınızı giriniz.  : ");
//int tarih = Convert.ToInt32(Console.ReadLine());

//int mevcutYil = DateTime.Now.Year;
//int yas = mevcutYil - tarih;


//Console.WriteLine(yas + " " + " yaşındasınız.");
//Console.ReadLine();


using System.Globalization;

Console.Write("Doğum tarihinizi GG/AA/YYYY şeklinde giriniz : ");
DateTime dogumTarihi = DateTime.Parse(Console.ReadLine(), new CultureInfo("tr-TR"));
DateTime bugun = DateTime.Today;
double yas;
TimeSpan tarihFarki = bugun.Subtract(dogumTarihi);
yas = tarihFarki.TotalHours / (365 * 24 + 6);
Console.WriteLine("Yaşınız: " + (int)yas); // int yazarak casting islemi yaptık. yuvarladık sayıyı