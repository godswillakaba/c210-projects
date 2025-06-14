using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();    
        }

        total += _customer.IsInUSA()?  5:35;

        return total;
    }


    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach(Product product in _products)
        {
            label += $"-{product.GetPackingLabel()}\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetShippingLabel()}";
    }
}
