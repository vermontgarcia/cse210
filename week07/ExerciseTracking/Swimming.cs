public class Swimming : Activity
{
  private double _laps;

  public Swimming(double minutes, double laps) : base("Swimming", minutes)
  {
    _laps = laps;
  }

  public override double GetDistance()
  {
    return _laps * 50 / 1000;
  }

  public override double GetPace()
  {
    return 60 / GetSpeed();
  }

  public override double GetSpeed()
  {
    return GetDistance() / base.Minutes * 60;
  }
}
