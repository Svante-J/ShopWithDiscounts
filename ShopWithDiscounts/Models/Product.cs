namespace ShopWithDiscounts.Models;

public class Product
{
    public char PLU { get; set; } 
    public string Name { get; set; } = "";
    public double Price { get; set; }
    public int Quantity { get; set; }
}
