public class Square : Shape
{
  private double _side;

  public double Side
  {
    get { return _side; }
    set { _side = value; }
  }
  public Square(double side, string color) : base(color)
  {
    _side = side;
  }

  public override double GetArea()
  {
    return _side * _side;
  }
}