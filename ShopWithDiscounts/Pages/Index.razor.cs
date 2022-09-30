using ShopWithDiscounts.Models;

namespace ShopWithDiscounts.Pages;

public partial class Index
{
    public List<Product> Products { get; set; } = MockProducts.MockProducts.Products.ToList();
}

