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
    LoadGoals();
    ListGoalDetails();
    DisplayPlayerInfo();
    ListGoalNames();
    // _goals[1].RecordEvent();
    DisplayPlayerInfo();
    ListGoalDetails();
    SaveGoals();

  }

  public void DisplayPlayerInfo()
  {
    int totalPoints = _goals.Sum(goal => goal.EarnedPoints);
    Console.WriteLine($"Score {totalPoints}");
  }

  public void ListGoalNames()
  {
    if (_goals.Count > 0)
    {
      foreach (int i in Enumerable.Range(0, _goals.Count))
      {
        Console.WriteLine($"{i + 1}. {_goals[i].Name}");
      }
    }
    else
    {
      Console.WriteLine("No goals to display...");
    }
  }

  public void ListGoalDetails()
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

  public void CreateGoal()
  {
    // SimpleGoal simpleGoal = new("Simple goal", "Simple goal description", 50);
    // EternalGoal eternalGoal = new("Eternal Goal", "Eternal goal description", 25);
    // ChecklistGoal checklistGoal = new("Checklist goal", "Checklist goal description", 50, 5, 200);

    // _goals.Add(simpleGoal);
    // _goals.Add(eternalGoal);
    // _goals.Add(checklistGoal);
  }

  public void RecordEvent()
  {
  }

  public void SaveGoals(string fileName = "goalsBackupAppFile.json")
  {
    var options = new JsonSerializerOptions { Converters = { new GoalConverter() }, WriteIndented = true };
    string jsonString = JsonSerializer.Serialize(_goals, options);
    File.WriteAllText(fileName, jsonString);
  }

  public void LoadGoals(string fileName = "goalsBackupAppFile.json")
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
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"General error: {ex.Message}");
    }
  }
}
