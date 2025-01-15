using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your percentage grade: ");
        int grade = int.Parse(Console.ReadLine());
        string letterGrade = "";

        // Calculating the Letter Grade
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else if (grade < 60)
        {
            letterGrade = "F";
        }

        // Finding the sign if any
        int remainder = grade % 10;
        string sign = "";
        if (remainder >= 7 && letterGrade != "A" && letterGrade != "F")
        {
            sign = "+";
        }
        else if (remainder < 3 && letterGrade != "F")
        {
            sign = "-";
        }

        // Presenting evaluation results to the user
        Console.WriteLine("");
        Console.WriteLine($"Your letter grade is \"{letterGrade}{sign}\"");
        if (grade >= 70)
        {
            Console.WriteLine("Congratilations, you passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you fail the class! Try harder next time and don't hesasitate to reach for help");
        }
        Console.WriteLine("");
    }
}
