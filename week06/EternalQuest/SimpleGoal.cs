public class SimpleGoal : Goal
{
  private bool _isComplete;

  public bool IsComplete
  {
    get { return _isComplete; }
    set { _isComplete = value; }
  }

  public SimpleGoal(string name, string description, int points) : base(name, description, points)
  {
    _isComplete = false;
  }

  public override string GetStringRepresentation()
  {
    return $"SimpleGoal|{Name}|{Description}|{Points}|{EarnedPoints}|{IsComplete}";
  }

  public override bool IsCompleted()
  {
    return _isComplete;
  }

  public override void RecordEvent()
  {
    if (!IsCompleted())
    {
      _isComplete = true;
      EarnedPoints = EarnedPoints + Points;
      Console.WriteLine($"Congratulations, you have earned {Points} points");
    }
  }
}