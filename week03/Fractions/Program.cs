using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Instantiating with each constructor method
        Fraction fractionOne = new();
        Console.WriteLine(fractionOne.GetFractionString());
        Console.WriteLine(fractionOne.GetDecimalValue());
        Fraction fractionTwo = new(9);
        Console.WriteLine(fractionTwo.GetFractionString());
        Console.WriteLine(fractionTwo.GetDecimalValue());
        Fraction fractionThree = new(3, 4);
        Console.WriteLine(fractionThree.GetFractionString());
        Console.WriteLine(fractionThree.GetDecimalValue());

        // Using Setter and Getter to update properties
        fractionOne.Top = 2;
        fractionOne.Bottom = 2;
        Console.WriteLine(fractionOne.GetFractionString());
        Console.WriteLine(fractionOne.GetDecimalValue());
        fractionTwo.Top = 4;
        fractionTwo.Bottom = 1;
        Console.WriteLine(fractionTwo.GetFractionString());
        Console.WriteLine(fractionTwo.GetDecimalValue());
        fractionThree.Top = 1;
        fractionThree.Bottom = 3;
        Console.WriteLine(fractionThree.GetFractionString());
        Console.WriteLine(fractionThree.GetDecimalValue());

    }
}