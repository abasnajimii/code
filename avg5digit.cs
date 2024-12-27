using System;
//عدد از ورودی گرفته و میانگین را در خروجی چاپ کند
class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        int sum = 0;

        Console.WriteLine("Please enter 5 integers:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            sum += numbers[i];
        }

        double average = sum / 5.0;
        Console.WriteLine($"The average of the entered numbers is: {average}");
    }
}
