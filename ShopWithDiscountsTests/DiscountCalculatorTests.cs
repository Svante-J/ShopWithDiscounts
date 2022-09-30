using ShopWithDiscounts.Models;
using ShopWithDiscounts.Services;

namespace ShopWithDiscountsTests;

public class DiscountCalculatorTests_Should
{
    public static IEnumerable<Product> Data =>
       new List<Product>
       {
            new Product { Name = "",Price = 4.99m, Quantity = 1, PLU ='A' },
            new Product { Name = "",Price = 4.49m, Quantity = 1, PLU ='A'},
       };

    [Fact]
    public void MyMethod_Add_ReturnTrue()
    {
        var result = DiscountCalculator.Add(1, 1);

        Assert.Equal(2, result);
    }

    // ToDO bara fact 
    //[Theory]
    //[MemberData(nameof(Data))]
    //public void TotalPrice_RoundsToNearestKrona_ReturnTrue(List<Product> products, int expected)
    //{
    //    var result = DiscountCalculator.TotalPrice(products);

    //    Assert.Equal(expected, result);
    //}
}

