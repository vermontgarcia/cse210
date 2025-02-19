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
    throw new NotImplementedException();
  }

  public override bool IsCompleted()
  {
    return _isComplete;
  }

  public override void RecordEvent()
  {
    throw new NotImplementedException();
  }
}