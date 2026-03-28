using System.Collections.Generic;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool GetIsUsa()
    {
        return _address.IsUsa();
    }

    public List<string> GetCustomer()
    {
        return new List<string> { _name, _address.GetAddress() };
    }
}
