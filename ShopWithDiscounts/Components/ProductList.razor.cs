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

    private void Buy(char plu)
    {
        CartService.AddProductToCart(plu);
    }
}

