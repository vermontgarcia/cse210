class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Mindfulness Project.");

        int choice;
        do
        {
            // Exceeding Requirements: Handeling Exceptions when no valid option entered by user
            try
            {
                DisplayMenu();
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            catch (FormatException)
            {
                Console.Clear();
                choice = 0;
            }

            string name;
            string description;

            switch (choice)
            {
                case 1:
                    name = "Breathing Activity";
                    Console.WriteLine(name);
                    description = "This activity will help you relax by breathing in and out slowly. Focus only in your breathing.";
                    BreathingActivity breathingActivity = new(name, description);
                    breathingActivity.StartActivity();
                    AddLogToTextFile(breathingActivity.GetEndingMessage());
                    break;
                case 2:
                    name = "Listing Activity";
                    Console.WriteLine(name);
                    description = "This activity will help you reflect on the good things in your life\nby having you list as many things as you can in a certain area.";
                    ListingActivity listingActivity = new(name, description);
                    listingActivity.StartActivity();
                    AddLogToTextFile(listingActivity.GetEndingMessage());
                    break;
                case 3:
                    name = "Reflecting Activity";
                    Console.WriteLine(name);
                    description = "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
                    ReflectingActivity reflectingActivity = new(name, description);
                    reflectingActivity.StartActivity();
                    AddLogToTextFile(reflectingActivity.GetEndingMessage());
                    break;
                case 9:
                    Console.WriteLine("Goodbye, comeback soon!");
                    Console.WriteLine();
                    break;
                case 8:
                    Console.WriteLine("History Logs!");
                    Console.WriteLine();
                    ShowLogsFromTexFile();
                    Console.WriteLine();
                    Console.Write("Press enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Please enter a valid option");
                    break;
            }
        } while (choice != 9);
    }

    // Function to display menu
    static void DisplayMenu()
    {

        string menu = @"
1. Breathing Activity.
2. Listing Activity.
3. Reflecting Activity.

8. Show logs.
9. Quit.
";

        Console.WriteLine(menu);
        Console.Write("What would you like to do? ");
    }

    // Function to get user input
    static string GetUserEntry(string prompt)
    {
        Console.Write($"{prompt} ");
        string userInput = Console.ReadLine();
        return userInput;
    }

    // Function to write to TXT file and populate entries
    static void AddLogToTextFile(string log)
    // Exceeding Requirements: Add log to file after activity has been completed
    {
        string fileName = "logs.txt";
        using StreamWriter outputFile = new(fileName, true);
        DateTime theCurrentTime = DateTime.Now;
        string dateText = $"{theCurrentTime.ToShortDateString()} @ {theCurrentTime.ToShortTimeString()}";
        outputFile.WriteLine($"{dateText}: {log}");
    }

    // Function to read from TXT file and populate entries
    static void ShowLogsFromTexFile()
    // Exceeding Requirements: Reading logs from file and display them to screen
    {
        string fileName = "logs.txt";
        string[] lines = File.ReadAllLines(fileName);
        string[] newLines = lines.ToArray();
        foreach (string line in newLines)
        {
            Console.WriteLine(line);
        }
    }

}