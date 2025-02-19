public class EternalGoal : Goal
{
  public EternalGoal(string name, string description, int points) : base(name, description, points) { }

  public override string GetStringRepresentation()
  {
    throw new NotImplementedException();
  }

  public override bool IsCompleted()
  {
    // TODO: Review IsCompleted implementation
    return true;
  }

  public override void RecordEvent()
  {
    throw new NotImplementedException();
  }
}