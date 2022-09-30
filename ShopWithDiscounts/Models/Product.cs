namespace ShopWithDiscounts.Models;

public class Product
{
    public char PLU { get; set; }
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public decimal TotalPrice
    {
        get
        {
            return Price * Quantity;
        }
    }
}