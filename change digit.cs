using System;
//دو عدد از ووردی گرفته و جای انها را با هم عوض کند
class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        // Swapping the values
        int temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;

        Console.WriteLine($"After swapping: First number = {firstNumber}, Second number = {secondNumber}");
    }
}
