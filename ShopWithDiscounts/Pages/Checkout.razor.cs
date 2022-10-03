using Microsoft.AspNetCore.Components;
using ShopWithDiscounts.Models;
using ShopWithDiscounts.Services;

namespace ShopWithDiscounts.Pages;

public partial class Checkout
{
    [Inject] public CartService? CartService { get; set; }
    public decimal TotalPrice { get; set; } 
    public int TotalPriceWithDiscount { get; set; }
    public decimal ÖresAvruindning { get; set; }  
    public int Items { get; set; }
    public decimal RubberGlovesDiscount { get; set; }
    public decimal StetooskopeDiscount { get; set; }
    public decimal TotalDiscount
    {
        get
        {
            return RubberGlovesDiscount + StetooskopeDiscount;
        }
    }

    protected override void OnInitialized()
    {

        Items = CheckoutCalculator.TotalItems(CartService!.SelectedItems);
        TotalPrice = CheckoutCalculator.TotalPrice(CartService!.SelectedItems);
        if (GetRubberGloves() >= 3)
        {           
            RubberGlovesDiscount = CheckoutCalculator.TreeForTwo(CartService!.SelectedItems);
        }
        if(GetStetoskopes() >= 3)
        {
            StetooskopeDiscount = CheckoutCalculator.TreeItemsDiscount(CartService!.SelectedItems);
        }
        TotalPriceWithDiscount = CheckoutCalculator.SubtractAndRoundTotalPrice(TotalDiscount, TotalPrice);
        
    }
    
    public int GetRubberGloves() => CartService!.SelectedItems.Where(p => p.PLU == 'A').Sum(p => p.Quantity);

    public int GetStetoskopes() => CartService!.SelectedItems.Where(p => p.PLU == 'B').Sum(p => p.Quantity);



}

