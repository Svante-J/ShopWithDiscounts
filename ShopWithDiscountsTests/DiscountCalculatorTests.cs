using ShopWithDiscounts.Services;

namespace ShopWithDiscountsTests;

public class DiscountCalculatorTests_Should
{
    [Fact]
    public void MyMethod_Add_ReturnTrue()
    {
       var result = DiscountCalculator.Add( 1 , 1);

        Assert.Equal(2, result);
    }
}

