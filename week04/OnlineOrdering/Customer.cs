public class Customer
{
  private string _fName;
  private string _lName;
  private Address _address;

  public Customer(string fName, string lName)
  {
    _fName = fName;
    _lName = lName;
  }
  public Customer(string fName, string lName, Address address)
  {
    _fName = fName;
    _lName = lName;
    _address = address;
  }

  public void SetAddress(Address address)
  {
    _address = address;
  }

  public bool IsUSALocated()
  {
    return _address.IsDomestic();
  }

  public string GetFullName()
  {
    return $"{_fName} {_lName}";
  }

  public string GetShippingAddress()
  {
    return _address.GetAddressLabel();
  }
}
