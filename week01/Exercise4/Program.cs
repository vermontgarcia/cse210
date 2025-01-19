using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int numberInput = 0;
        List<int> numbers = new List<int>();
        do
        {
            try
            {
                Console.Write("Enter a number: ");
                numberInput = int.Parse(Console.ReadLine());
                if (numberInput != 0)
                {
                    numbers.Add(numberInput);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number");
            }
        } while (numberInput != 0);

        // Computing the results
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();
        numbers.Sort();
        List<int> positiveNumbers = numbers.Where(x => x > 0).ToList();
        int minPositive = positiveNumbers.Min();

        // Output the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The maximum number is: {max}");
        Console.WriteLine($"Smallest positive number: {minPositive}");
        Console.WriteLine($"Sorted numbers: {string.Join(", ", numbers)}");
    }
}
