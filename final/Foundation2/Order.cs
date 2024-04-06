public class Order
{
    private Customer _customer;
    private List<Product> _productList;

    public Order(Customer customer)
    {
        _customer = customer;
        _productList = [];
    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }
    public double TotalPrice()
    {
        double total = 0;
        foreach (Product product in _productList)
        {
            total = total + product.TotalPrice();
        }

        if (_customer.IsUSA())
        {
            return total + 5;
        }
        else
        {
            return total + 35;
        }
    }
    public void CreatePackingLabel()
    {
        foreach (Product product in _productList)
        {
            Console.WriteLine(product.GetName());
            Console.WriteLine(product.GetProductId());
        }
    }
    public void CreateShippingLabel()
    {
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress());
    }
}