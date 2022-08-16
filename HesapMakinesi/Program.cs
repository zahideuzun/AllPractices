static void BaslikGir()
{
    Console.WriteLine("*** Hesap Makinesi ***");
}
BaslikGir();

double number1, number2;

Console.Write("İşlem yapmak istediğiniz ilk sayıyı giriniz: ");
number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("İşlem yapmak istediğiniz ikinci sayıyı giriniz: ");
number2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Yapmak istediğiniz işlemi giriniz (+ , - , * , / , %) : ");
string islem = Console.ReadLine();

Calculate(number1, number2, islem);

static void Calculate(double number1, double number2, string islem)
{
    double result = 0; // neden?? 
    switch (islem)
    {
        case "+":
            result = number1 + number2;
            break;
        case "-":
            result = number1 - number2;
            break;
        case "*":
            result = number1 * number2;
            break;
        case "/":
            result = number1 / number2;
            break;
        case "%":
            result = number1 % number2;
            break;
        default:
            Console.WriteLine("Yanlış işlem girdiniz!!!!!");
            break;
    }
    Console.WriteLine(" Sonuç: " + " " + result);
    Console.ReadLine();

}






