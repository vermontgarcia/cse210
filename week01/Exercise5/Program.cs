using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string name = PromtUserName();
        int favoriteNumber = PromptUserNumber();
        int squareNumber = SquareNumber(favoriteNumber);
        DisplayResult(name, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to this program!");
    }

    static string PromtUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        return textInfo.ToTitleCase(name.ToLower());
    }

    static int PromptUserNumber()
    {
        do
        {
            try
            {
                Console.Write("Please enter your favorite number: ");
                int favoriteNumber = int.Parse(Console.ReadLine());
                return favoriteNumber;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number");
            }
        } while (true);
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squareNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNumber}");
    }
}