public class ChecklistGoal : Goal
{
  private int _amountCompleted;
  private int _target;
  private int _bonus;


  public int AmountCompleted
  {
    get { return _amountCompleted; }
    set { _amountCompleted = value; }
  }
  public int Target
  {
    get { return _target; }
    set { _target = value; }
  }
  public int Bonus
  {
    get { return _bonus; }
    set { _bonus = value; }
  }

  public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
  {
    _amountCompleted = 0;
    _target = target;
    _bonus = bonus;
  }

  public override string GetStringRepresentation()
  {
    throw new NotImplementedException();
  }

  public override bool IsCompleted()
  {
    if (_amountCompleted == _target)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public override void RecordEvent()
  {
    _amountCompleted++;
  }
}