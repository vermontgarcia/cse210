public abstract class Activity
{
  private DateTime _dateTime;
  private double _minutes;
  private string _name;

  public Activity(string name, double minutes)
  {
    _dateTime = DateTime.Now;
    _name = name;
    _minutes = minutes;
  }

  public double Minutes
  {
    get { return _minutes; }
  }

  public abstract double GetDistance();

  public abstract double GetSpeed();

  public abstract double GetPace();

  public string GetSummary()
  {
    return $"{_dateTime} {_name} ({_minutes} min): Distance {GetDistance():F2} km, Speed: {GetSpeed():F2} km/h, Pace: {GetPace():F2} min/km";
  }
}
