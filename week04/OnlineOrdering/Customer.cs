public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _customerAddress = address;
    }

    public bool IsUsa()
    {
        return _customerAddress.IsUSA();
    }

    public string GetCustomerProfile()
    {
        return $"{_customerName}\n{_customerAddress.GetFullAddress()}";
    }
}