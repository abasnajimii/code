using System;
//سه عدد از ورودی گرفته و انرا مانند یک کاشین حساب به ترتیب ورود چاپ کند
class Program
{
    static void Main()
    {
        Console.Write("Enter the first digit: ");
        int firstDigit = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second digit: ");
        int secondDigit = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third digit: ");
        int thirdDigit = Convert.ToInt32(Console.ReadLine());

        int threeDigitNumber = firstDigit * 100 + secondDigit * 10 + thirdDigit;

        Console.WriteLine($"The three-digit number formed is: {threeDigitNumber}");
    }
}
