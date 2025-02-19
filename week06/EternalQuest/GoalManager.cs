using System.Text.Json;

public class GoalManager
{
  private List<Goal> _goals;
  private int _score;

  public GoalManager()
  {
    _goals = [];
    _score = 0;
  }

  public void Start()
  {
  }

  public void DisplayPlayerInfo()
  {
  }

  public void ListGoalNames()
  {
  }

  public void ListGoalDetails()
  {
    if (_goals.Count > 0)
    {
      foreach (Goal goal in _goals)
      {
        Console.WriteLine(goal.GetDetailsString());
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

  public void SaveGoals(string fileName)
  {
    var options = new JsonSerializerOptions { Converters = { new GoalConverter() }, WriteIndented = true };
    string jsonString = JsonSerializer.Serialize(_goals, options);
    File.WriteAllText(fileName, jsonString);
  }

  public void LoadGoals(string fileName)
  {
    string jsonString = File.ReadAllText(fileName);
    var options = new JsonSerializerOptions { Converters = { new GoalConverter() }, WriteIndented = true };
    List<Goal> deserializedGoals = JsonSerializer.Deserialize<List<Goal>>(jsonString, options);
    _goals = deserializedGoals;
  }
}
