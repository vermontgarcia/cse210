public class Product
{
  private int _id;
  private string _name;
  private double _price;
  private int _quantity;

  public Product(int id, string name, double price, int quantity = 1)
  {
    _id = id;
    _name = name;
    _price = price;
    _quantity = quantity;
  }

  public void SetQuantity(int quantity)
  {
    _quantity = quantity;
  }

  public string GetPackingDetails()
  {
    return $"{_id} - {_name} - {_quantity}";
  }

  public double GetTotalCost()
  {
    return _price * _quantity;
  }
}
