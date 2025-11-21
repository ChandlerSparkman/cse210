public class Product
{
    private string _productName;
    private int _productID;
    private double _productPrice;
    private int _productQuantity;

    public Product(string name, int id, double price, int quantity)
    {
        _productName = name;
        _productID = id;
        _productPrice = price;
        _productQuantity = quantity;
    }

    public double ComputeCost()
    {
        return _productQuantity * _productPrice;
    }

    public string GetProductInfo()
    {
        return $"ID{_productID}: {_productName} x({_productQuantity})";
    }
}