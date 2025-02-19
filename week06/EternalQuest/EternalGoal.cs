public class EternalGoal : Goal
{
  public EternalGoal(string name, string description, int points) : base(name, description, points) { }

  public override string GetStringRepresentation()
  {
    return $"EternalGoal|{Name}|{Description}|{Points}|{EarnedPoints}";
  }

  public override bool IsCompleted()
  {
    // Always will be false since it is Eternal
    return false;
  }

  public override void RecordEvent()
  {
    EarnedPoints = EarnedPoints + Points;
    Console.WriteLine($"Congratulations, you have earned {Points} points");
  }
}