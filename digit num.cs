using System;
//عدد گرفته و بگوید چند رقمی است
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        int digitCount = input.Length;

        Console.WriteLine($"The number {input} has {digitCount} digits.");
    }
}
