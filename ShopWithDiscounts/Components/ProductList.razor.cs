using Microsoft.AspNetCore.Components;
using ShopWithDiscounts.Models;
using ShopWithDiscounts.Services;

namespace ShopWithDiscounts.Components;

public partial class ProductList
{
    [Inject] public CartService? CartService { get; set; }

    [EditorRequired]
    [Parameter] public List<Product> Products { get; set; } = new();
    [Parameter] public bool DisplayBuyButton { get; set; }
    public int Quantity { get; set; }

    private void AddToCart(Product product, int qty)
    {
        if (qty > 0)
        {
            var newProduct = new Product { Name = product.Name, PLU = product.PLU, Price = product.Price, Quantity = qty };
       
            CartService!.AddProductToCart(newProduct);
        }
        Quantity = 0;
    }
}

