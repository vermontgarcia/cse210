public class Running : Activity
{
  private double _distance;

  public Running(double minutes, double distance) : base("Running", minutes)
  {
    _distance = distance;
  }

  public override double GetDistance()
  {
    return _distance;
  }

  public override double GetPace()
  {
    return base.Minutes / _distance;
  }

  public override double GetSpeed()
  {
    return _distance * 60 / base.Minutes;
  }
}
