using System;
using System.Linq;
//تعدادی وزن گرفته و بیشترین و کمترین را در خروجی چاپ کند
class Program
{
    static void Main()
    {
        Console.Write("Enter the number of individuals: ");
        int numberOfIndividuals = Convert.ToInt32(Console.ReadLine());

        double[] weights = new double[numberOfIndividuals];

        for (int i = 0; i < numberOfIndividuals; i++)
        {
            Console.Write($"Enter the weight of individual {i + 1}: ");
            weights[i] = Convert.ToDouble(Console.ReadLine());
        }

        double maxWeight = weights.Max();
        double minWeight = weights.Min();

        Console.WriteLine($"The maximum weight is: {maxWeight}");
        Console.WriteLine($"The minimum weight is: {minWeight}");
    }
}
