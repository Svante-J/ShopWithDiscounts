using Microsoft.AspNetCore.Components;
using ShopWithDiscounts.Services;

namespace ShopWithDiscounts.Pages;

    public partial class Checkout
    {
    [Inject] public CartService? CartService { get; set; }
    }

