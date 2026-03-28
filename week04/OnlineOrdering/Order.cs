using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float GetTotalPrice()
    {
        float total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Shipping cost: $5 if USA, $35 otherwise
        total += _customer.GetIsUsa() ? 5 : 35;
        return total;
    }

    public string GetPacking()
    {
        List<string> packingList = new List<string>();
        foreach (Product product in _products)
        {
            packingList.Add(product.GetPackingInfo());
        }
        return string.Join("\n", packingList);
    }

    public List<string> GetShippingLabel()
    {
        return _customer.GetCustomer();
    }
}
