using ShopWithDiscounts.Models;
using System.Linq;

namespace ShopWithDiscounts.Services;

    public class CartService
    {
    public List<Product> SelectedItems { get; set; } = new();

    public void AddProductToCart(char plu)
    {
        var product = MockProducts.MockProducts.Products.First(p => p.PLU == plu);

        if (SelectedItems.Contains(product) is false)
        {
            SelectedItems.Add(product);
        }
        
    }
}
