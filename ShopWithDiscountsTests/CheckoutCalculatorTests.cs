using ShopWithDiscounts.Models;
using ShopWithDiscounts.Services;
using Xunit.Sdk;

namespace ShopWithDiscountsTests;

public class DiscountCalculatorTests_Should
{  
    [Theory]
    [InlineData(0, 0.03, 0)]
    [InlineData(0, 1.03, 1)]
    [InlineData(0, 1.49, 1)]
    [InlineData(0, 1.50, 2)]
    [InlineData(0, 2.90, 3)]
    public void SubtractAndRoundTotalPrice_RoundsDownRoundsUpp_ReturnInteger(decimal discount, decimal price, int expected)
    {        
        var result = CheckoutCalculator.SubtractAndRoundTotalPrice(discount, price);        

        Assert.Equal(expected, result);
    } 

    [Fact]
    public void SubtractAndRoundTotalPrice_CorrectSubtraktion_ReturnInt()
    {
        var discount = 499.50m;
        var price = 501m;
        var result = CheckoutCalculator.SubtractAndRoundTotalPrice(discount, price);
        var expected = 2;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void TotalPrice_ReturnCorrectPrice_ReturnTrue()
    {
        var testList = new List<Product> { new Product { Quantity = 5, Price = 1.01m } };  
        var result = CheckoutCalculator.TotalPrice(testList);
        var expected = 5.05m;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void TotalItems_ReuturnItemCount_ReturnTrue()
    {
        var testList = new List<Product> { new Product { Quantity = 5, Price = 1.01m } };
        testList.Add(new Product { Quantity = 1 });
        var result = CheckoutCalculator.TotalItems(testList);
        var expected = 6;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void TreeItemsDiscount_ReuturnDiscount_ReturnTrue()
    {
        var testList = new List<Product> { new Product { Quantity = 5, PLU = 'B'} };
       
        var result = CheckoutCalculator.TreeItemsDiscount(testList);
        var expected = 198m;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void TreeItemsDiscount_ReuturnDoubleDiscount_ReturnTrue()
    {
        var testList = new List<Product> { new Product { Quantity = 6, PLU = 'B' } };

        var result = CheckoutCalculator.TreeItemsDiscount(testList);
        var expected = 396m;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void TreeItemsDiscount_WrongPLU_ReturnZero()
    {
        var testList = new List<Product> { new Product { Quantity = 6, PLU = 'F' } };

        var result = CheckoutCalculator.TreeItemsDiscount(testList);
        var expected = 0;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void TreeForTwo_CalculateDiscount_ReturnTrue()
    {
        var testList = new List<Product> { new Product { Quantity = 6, PLU = 'A' } };

        var result = CheckoutCalculator.TreeForTwo(testList);
        var expected = 119.80m;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void TreeForTwo__WrongPLU_ReturnZero()
    {
        var testList = new List<Product> { new Product { Quantity = 6, PLU = 'B' } };

        var result = CheckoutCalculator.TreeForTwo(testList);
        var expected = 0;

        Assert.Equal(expected, result);
    }

}

