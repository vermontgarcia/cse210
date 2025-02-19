using System.Reflection.Metadata.Ecma335;

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
    return $"ChecklistGoal|{Name}|{Description}|{Points}|{EarnedPoints}|{AmountCompleted}|{Target}|{Bonus}";
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
    if (!IsCompleted())
    {
      int pointsToAdd = Points;
      _amountCompleted++;
      if (_amountCompleted == Target)
      {
        pointsToAdd = pointsToAdd + _bonus;
      }
      EarnedPoints = EarnedPoints + pointsToAdd;
      Console.WriteLine($"Congratulations, you have earned {pointsToAdd} points");
    }
  }

  public override string GetDetailsString()
  {
    return $"{base.GetDetailsString()} - Completed {_amountCompleted}/{Target}";
  }
}