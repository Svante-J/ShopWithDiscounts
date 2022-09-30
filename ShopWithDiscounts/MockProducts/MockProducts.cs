using ShopWithDiscounts.Models;
using System.Collections.Immutable;
using System.Xml.Linq;

namespace ShopWithDiscounts.MockProducts;

public static class MockProducts
{
    public static readonly ImmutableList<Product> Products = ImmutableList.CreateRange(new List<Product>
        {
            new ()
            {
            PLU = 'A',
            Name = "Gummihansker",
            Price = (decimal)59.90,
            },
             new ()
            {
                PLU = 'B',
            Name = "Stetoskop",
            Price = 399,
            },
              new ()
            {
                PLU = 'C',
            Name = "Talkum",
            Price = (decimal)19.54,
            },
        });
}

