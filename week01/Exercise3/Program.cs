using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;
            int guessedTimes = 0;
            do
            {
                Console.Write("Enter your guess: ");
                // Handle exception when user not provide a valid numerical input
                try
                {
                    guess = int.Parse(Console.ReadLine());
                    guessedTimes += 1;
                    if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it! It took you {guessedTimes} times!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number");
                }
            } while (guess != magicNumber);

            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();

        } while (playAgain.ToLower() == "yes");
    }
}
