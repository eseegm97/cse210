public class Product
{
    private string name;
    private string productId;
    private double pricePerUnit;
    private int quantity;

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public string Name
    {
        get { return name; }
    }

    public string ProductId
    {
        get { return productId; }
    }

    public double PricePerUnit
    {
        get { return pricePerUnit; }
    }

    public int Quantity
    {
        get { return quantity; }
    }

    public double GetTotalCost()
    {
        return pricePerUnit * quantity;
    }
}