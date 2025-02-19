using System.Text.Json;

public class GoalManager
{
  private List<Goal> _goals;
  // private int _score;

  public GoalManager()
  {
    _goals = [];
    // _score = 0;
  }

  public void Start()
  {
    // Exceeding Requirements Loading from file on starting
    LoadGoals();
    Thread.Sleep(2000);
    int choice;
    do
    {
      // Exceeding Requirements: Handeling Exceptions when no valid option entered by user
      try
      {
        DisplayMainMenu();
        choice = int.Parse(Console.ReadLine());
        Console.Clear();
      }
      catch (FormatException)
      {
        Console.Clear();
        choice = 0;
      }

      switch (choice)
      {
        case 1:
          CreateGoalMenu();
          break;
        case 2:
          ListGoals();
          break;
        case 3:
          RecordEvent();
          break;
        case 4:
          // Exceeding Requirements Exporting to a JSON File
          PrintHeader("Export JSON file");
          Console.Write("Enter the filename: ");
          string expportName = Console.ReadLine();
          SaveGoals(expportName);
          break;
        case 5:
          // Exceeding Requirements Importing from a JSON File
          PrintHeader("Import JSON file");
          Console.Write("Enter the filename: ");
          string importName = Console.ReadLine();
          LoadGoals(importName);
          break;
        case 9:
          // Exceeding Requirements Saving to file on quit
          SaveGoals();
          Console.WriteLine("Goodbye, comeback soon!");
          Console.WriteLine();
          break;
        default:
          Console.WriteLine("Please enter a valid option");
          Thread.Sleep(800);
          break;
      }
    } while (choice != 9);
  }

  private void CreateGoalMenu()
  {
    int choice;
    do
    {
      // Exceeding Requirements: Handeling Exceptions when no valid option entered by user
      try
      {
        DisplayCreateGoalMenu();
        choice = int.Parse(Console.ReadLine());
        Console.Clear();
      }
      catch (FormatException)
      {
        Console.Clear();
        choice = 0;
      }

      switch (choice)
      {
        case 1:
          CreateSimpleGoal();
          choice = 8;
          break;
        case 2:
          CreateEternalGoal();
          choice = 8;
          break;
        case 3:
          CreateCheclistGoal();
          choice = 8;
          break;
        case 8:
          break;
        default:
          Console.WriteLine("Please enter a valid option");
          Thread.Sleep(800);
          break;
      }
    } while (choice != 8);

  }

  private void PrintHeader(string title)
  {
    ClearScreen();
    DisplayPlayerInfo();
    Console.WriteLine();
    Console.WriteLine(title);
    Console.WriteLine();
  }

  private void CreateSimpleGoal()
  {
    PrintHeader("Simple Goal");
    Console.Write("Enter the name: ");
    string name = Console.ReadLine();
    Console.Write("Enter a short description: ");
    string description = Console.ReadLine();
    int points = GetIntNumberInput("Enter the number of points to achive: ");

    SimpleGoal newGoal = new(name, description, points);
    _goals.Add(newGoal);
  }

  private void CreateEternalGoal()
  {
    PrintHeader("Eternal Goal");
    Console.Write("Enter the name: ");
    string name = Console.ReadLine();
    Console.Write("Enter a short description: ");
    string description = Console.ReadLine();
    int points = GetIntNumberInput("Enter the number of points: ");

    EternalGoal newGoal = new(name, description, points);
    _goals.Add(newGoal);
  }

  private void CreateCheclistGoal()
  {
    PrintHeader("Checklist Goal");
    Console.Write("Enter the name: ");
    string name = Console.ReadLine();
    Console.Write("Enter a short description: ");
    string description = Console.ReadLine();
    int points = GetIntNumberInput("Enter the number of points: ");
    int target = GetIntNumberInput("Enter the number of times to get a bonus: ");
    int bonus = GetIntNumberInput("Enter bonus points: ");

    ChecklistGoal newGoal = new(name, description, points, target, bonus);
    _goals.Add(newGoal);
  }

  private void ListGoals()
  {
    PrintHeader("List of Goals");
    ListGoalDetails();
    Console.WriteLine();
    Console.Write("Please enter to continue...");
    Console.ReadLine();
  }

  private int GetIntNumberInput(string message)
  {
    do
    {
      try
      {
        Console.Write(message);
        int numberInput = int.Parse(Console.ReadLine());
        return numberInput;
      }
      catch (FormatException)
      {
        Console.WriteLine("Please enter a valid number.");
      }
    } while (true);
  }

  private void DisplayPlayerInfo()
  {
    // Exceeding Requirements Updating score from goal instances Adding Goals count to Player info
    int totalPoints = _goals.Sum(goal => goal.EarnedPoints);
    Console.WriteLine($"Score {totalPoints} - Total Goals {_goals.Count}");
  }

  private void ListGoalNames()
  {
    if (_goals.Count > 0)
    {
      foreach (int i in Enumerable.Range(0, _goals.Count))
      {
        // Exceeding Requirements showing to the user completed goals
        string pendingOrCompleted = _goals[i].IsCompleted() ? "- " : $"{i + 1}.";
        Console.WriteLine($"{pendingOrCompleted} {_goals[i].Name}");
      }
    }
    else
    {
      Console.WriteLine("No goals to display...");
    }
  }

  private void ListGoalDetails()
  {
    if (_goals.Count > 0)
    {
      foreach (int i in Enumerable.Range(0, _goals.Count))
      {
        Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
      }
    }
    else
    {
      Console.WriteLine("No goals to display...");
    }
  }

  private void RecordEvent()
  {
    PrintHeader("Record an Achivement");
    ListGoalNames();
    Console.WriteLine();
    Console.WriteLine("Completed goals are marked with \"-\"");
    Console.WriteLine();
    int goalNumber = GetIntNumberInput("Select the goal you did an achivement: ");
    if (goalNumber > 0 && goalNumber <= _goals.Count)
    {
      _goals[goalNumber - 1].RecordEvent();
      Console.WriteLine();
      Console.Write("Please enter to continue...");
      Console.ReadLine();
    }
    else
    {
      Console.WriteLine();
      Console.WriteLine("Not a valid option. Try again");
      Thread.Sleep(1500);
    }
  }

  private void SaveGoals(string fileName = "goalsBackupAppFile.json")
  {
    var options = new JsonSerializerOptions { Converters = { new GoalConverter() }, WriteIndented = true };
    string jsonString = JsonSerializer.Serialize(_goals, options);
    File.WriteAllText(fileName, jsonString);
  }

  private void LoadGoals(string fileName = "goalsBackupAppFile.json")
  {
    try
    {
      string jsonString = File.ReadAllText(fileName);
      var options = new JsonSerializerOptions { Converters = { new GoalConverter() }, WriteIndented = true };
      List<Goal> deserializedGoals = JsonSerializer.Deserialize<List<Goal>>(jsonString, options);
      _goals = deserializedGoals;

    }
    catch (FileNotFoundException ex)
    {
      if (fileName != "goalsBackupAppFile.json")
      {
        Console.WriteLine($"Error: File not found - {ex.FileName}");
        Console.WriteLine();
        Console.Write("Press enter to continue...");
        Console.ReadLine();
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"General error: {ex.Message}");
    }
  }

  private void DisplayMainMenu()
  {
    string menu = @"
1. Create New Goal.
2. List Goals.
3. Record Event.

4. Export Goals (JSON).
5. Import Goals (JSON).

9. Quit.
";

    ClearScreen();

    DisplayPlayerInfo();

    Console.WriteLine(menu);
    Console.Write("What would you like to do? ");
  }

  private void DisplayCreateGoalMenu()
  {
    string menu = @"
Select the type of goal:

1. Simple Goal.
2. Eternal Goal.
3. Checklist Goal.

8. Go Back.
";

    ClearScreen();

    DisplayPlayerInfo();

    Console.WriteLine(menu);
    Console.Write("What would you like to do? ");
  }

  private void ClearScreen()
  {
    Console.Clear();
  }
}
