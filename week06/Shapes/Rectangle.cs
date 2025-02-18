public class Rectangle : Shape
{
  private double _width;
  private double _length;

  public Rectangle(double width, double length, string color) : base(color)
  {
    _width = width;
    _length = length;
  }

  public double Width
  {
    get { return _width; }
    set { _width = value; }
  }
  public double Length
  {
    get { return _length; }
    set { _length = value; }
  }

  public override double GetArea()
  {
    return _width * _length;
  }
}