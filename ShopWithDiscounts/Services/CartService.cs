using ShopWithDiscounts.Models;
using System.Linq;

namespace ShopWithDiscounts.Services;

public class CartService
{
    public List<Product> SelectedItems { get; set; } = new();

    public void AddProductToCart(Product product)
    {
        SelectedItems.Add(product);
    }
}
