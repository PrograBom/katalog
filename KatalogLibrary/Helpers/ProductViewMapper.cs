using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatalogLibrary.Views;
using KatalogLibrary.Models;

namespace KatalogLibrary.Helpers
{
    public class ProductViewMapper : IMapper<Product, ProductView>
    {
        public ProductView Map(Product source)
        {
            return new ProductView(source);
        }

        public List<ProductView> MapList(List<Product> products)
        {
            return products.Select(product => Map(product)).ToList();
        }
    }
}
