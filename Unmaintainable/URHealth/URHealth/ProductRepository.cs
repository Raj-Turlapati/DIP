using System;
using System.Collections.Generic;

namespace URHealth
{
    public class ProductRepository
    {
        private DBContext dbContext;

        public ProductRepository()
        {
            dbContext = new DBContext();
        }
        public IList<Product> GetAllProducts()
        {
            IList<Product> products = new List<Product>();

            products = dbContext.Products;
            
            return products;
        }
    }
}
