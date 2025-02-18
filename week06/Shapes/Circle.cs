public class Circle : Shape
{
  private double _radius;

  public double Radius
  {
    get { return _radius; }
    set { _radius = value; }
  }
  public Circle(double radius, string color) : base(color)
  {
    _radius = radius;
  }
  public override double GetArea()
  {
    return Math.Pow(_radius, 2) * Math.PI;
  }
}