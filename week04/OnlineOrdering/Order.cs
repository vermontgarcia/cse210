public class Order
{
  private Customer _customer;
  private List<Product> _products;


  public Order(Customer customer)
  {
    _customer = customer;
    _products = [];
  }

  public Order(Customer customer, List<Product> products)
  {
    _customer = customer;
    _products = products;
  }

  public void AddProduct(Product product)
  {
    _products.Add(product);
  }

  public void DeleteProduct(int id)
  {
    int index = _products.FindIndex(product => product.GetId() == id);
    if (index >= 0 && index < _products.Count)
    {
      _products.RemoveAt(index);
    }
    else
    {
      Console.WriteLine("Product not in order");
    }
  }

  public double GetTotalCost()
  {
    double totalCost = 0;
    if (_customer.IsUSALocated())
    {
      totalCost += 5;
    }
    else
    {
      totalCost += 35;
    }
    return _products.Sum(product => product.GetTotalCost()) + totalCost;
  }

  public string GetPackingLabel()
  {
    string packingLabel = "Product ID, Product Name, Quantity\n";
    foreach (Product product in _products)
    {
      packingLabel = $"{packingLabel}{product.GetPackingDetails()}\n";
    }
    return packingLabel;
  }

  public string GetShippingLabel()
  {
    return $"{_customer.GetFullName()}\n{_customer.GetShippingAddress()}";
  }
}