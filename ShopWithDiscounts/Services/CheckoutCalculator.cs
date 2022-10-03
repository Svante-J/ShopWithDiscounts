using ShopWithDiscounts.Models;

namespace ShopWithDiscounts.Services;

public static class CheckoutCalculator
{ 
    public static decimal TreeForTwo(List<Product> products)    {
        var items = products.Where(p => p.PLU == 'A').Sum(p => p.Quantity);        
        var discount = items / 3 * 59.90m;
        
        return discount;
    }

    public static decimal TreeItemsDiscount(List<Product> products)
    {
        var items = products.Where(p => p.PLU == 'B').Sum(p => p.Quantity);
        var discount = items / 3 * 198m;

        return discount;
    }

    public static int TotalItems(List<Product> products) => products.Sum(p => p.Quantity);

    public static decimal TotalPrice(List<Product> products) => products.Sum(p => p.TotalPrice);    

    public static int SubtractAndRoundTotalPrice(decimal discount, decimal price)
    {
        var totalPrice = price - discount;
        var rounded = Math.Round(totalPrice, 0, 0);       
        int total = decimal.ToInt32(rounded);
        return total;
    }
}

