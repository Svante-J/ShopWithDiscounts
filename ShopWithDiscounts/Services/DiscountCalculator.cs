using ShopWithDiscounts.Models;

namespace ShopWithDiscounts.Services;

public static class DiscountCalculator
{
    public static int Add(int x, int y)
    {
        return x + y;
    }
    public static int TreeForTwo(List<Product> products)
    {
        var items = products.Select(p => p.PLU == 'A');
            
            
        // do math
        return 1;
    }
    public static int TotalItems(List<Product> products) => products.Sum(p => p.Quantity);

    public static int TotalDiscount(List<Product> products)
    {


        return 1;
    }

    public static int TotalPrice(List<Product> products)
    {
        var totalPrice = products.Sum(p => p.TotalPrice);
        var rounded = Math.Round(totalPrice, 0, 0);
        decimal oresAvrundning = totalPrice - rounded;
        int total = decimal.ToInt32(rounded);
        return total;
    }
}

