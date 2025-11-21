public class Order
{
    Customer _customer;
    List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double ComputeTotalCost()
    {
        double cost = 0;
        foreach (Product product in _products)
        {
            cost += product.ComputeCost();
        }
        
        if (_customer.IsUsa() == true)
        {
            cost += 5;
        }
        else
        {
            cost += 35;
        }

        cost = Math.Round(cost, 2);

        return cost;
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += product.GetProductInfo() + "\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return _customer.GetCustomerProfile();
    }
}