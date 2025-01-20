using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.Clear();
        Console.WriteLine("Welcome to the Journal Project.");

        Journal journal = new Journal();

        int choice = 0;

        do
        {
            // Handling exception when not a number is typed
            try
            {
                DisplayMenu();
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                string fileName = "";

                switch (choice)
                {
                    case 1:
                        // Add a new entry
                        string prompt = promptGenerator.GetRandomPrompt();
                        string userEntry = GetUserEntry(prompt);
                        Entry newEntry = new Entry(prompt, userEntry);
                        journal.AddEntry(newEntry);
                        break;
                    case 2:
                        // Display all entries
                        journal.DisplayAllEntries();
                        break;
                    case 3:
                        // Load Journal from file
                        fileName = GetFileName();
                        // Two file options available to expot and import from files JSON and TXT
                        if (fileName.Contains(".txt"))
                        {
                            journal.LoadFromTextFile(fileName);
                        }
                        else if (fileName.Contains(".json"))
                        {
                            journal.ReadFromJsonFile(fileName);
                        }
                        else
                        {
                            Console.WriteLine("Not valid extension");
                        }

                        break;
                    case 4:
                        // Write Journal to file
                        fileName = GetFileName();
                        // Two file options available to expot and import from files JSON and TXT
                        if (fileName.Contains("txt"))
                        {
                            journal.SaveToTextFile(fileName);
                        }
                        else if (fileName.Contains("json"))
                        {
                            journal.SaveToJsonFile(fileName);
                        }
                        else
                        {
                            Console.WriteLine("Not valid extension");
                        }
                        break;
                    case 9:
                        // Exit
                        Console.WriteLine("Good bye, comeback soon!");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid option");
            }

        } while (choice != 9);

    }

    // Function to display menu
    static void DisplayMenu()
    {

        string menu = @"
1. Write a new entry.
2. Display journal.
3. Load from file.
4. Write to file.

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

    // Function to get filename from user
    static string GetFileName()
    {
        Console.Write("Enter file name (include extension .txt or .json): ");
        string userInput = Console.ReadLine();
        return userInput;
    }
}