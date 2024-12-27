using System;
//یک عدد سه رقمی گرفته و انرا برعکس کند
class Program
{
    static void Main()
    {
        Console.Write("Enter a three-digit number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int reversedNumber = ReverseNumber(number);
        Console.WriteLine($"The reversed number is: {reversedNumber}");
    }

    static int ReverseNumber(int num)
    {
        int hundreds = num / 100;
        int tens = (num / 10) % 10;
        int units = num % 10;

        return units * 100 + tens * 10 + hundreds;
    }
}
