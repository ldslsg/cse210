public class Order
{
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    public decimal GetTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in Products)
        {
            totalCost += product.GetTotalPrice();
        }

        totalCost += Customer.LivesInUSA() ? 5 : 35;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (var product in Products)
        {
            label += $"Name: {product.Name}, Product ID: {product.ProductId}\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return Customer.Address.ToString();
    }
}
