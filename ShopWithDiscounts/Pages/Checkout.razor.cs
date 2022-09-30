using Microsoft.AspNetCore.Components;
using ShopWithDiscounts.Models;
using ShopWithDiscounts.Services;

namespace ShopWithDiscounts.Pages;

public partial class Checkout
{
    [Inject] public CartService? CartService { get; set; }
    public int TotalPrice { get; set; } 
    public decimal ÖresAvruindning { get; set; }  
    public int Items { get; set; }

    protected override void OnInitialized()
    {
        Items = DiscountCalculator.TotalItems(CartService!.SelectedItems);
        TotalPrice = DiscountCalculator.TotalPrice(CartService!.SelectedItems);
    }

    public int TotalItems(List<Product> products)
    {
        var items = products.Sum(p => p.Quantity);
        return items;
    }
}

