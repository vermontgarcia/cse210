public class Address
{
  private string _address;
  private string _city;
  private string _state;
  private int _zipCode;
  private string _country;

  public Address(string address, string city, string state, int zipCode, string country)
  {
    _address = address;
    _city = city;
    _state = state;
    _zipCode = zipCode;
    _country = country;
  }

  public bool IsDomestic()
  {
    return _country.ToLower() == "usa";
  }

  public string GetAddressLabel()
  {
    return $"{_address}\n{_city}, {_state}, {_country}\n{_zipCode}";
  }
}