public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }
    public bool IsUSA()
    {
        return _address.IsUSA();
    }
    public string GetAddress()
    {
        return _address.GetAddress();
    }
}