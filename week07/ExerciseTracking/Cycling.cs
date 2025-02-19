public class Cycling : Activity
{
  private double _speed;

  public Cycling(double minutes, double speed) : base("Cycling", minutes)
  {
    _speed = speed;
  }

  public override double GetDistance()
  {
    return _speed * base.Minutes / 60;
  }

  public override double GetPace()
  {
    return 60 / _speed;
  }

  public override double GetSpeed()
  {
    return _speed;
  }
}
