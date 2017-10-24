using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URHealth
{
   public class ProductService
    {
        private ProductRepository _productRepository; 

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public IList<Product> GetAllProducts()
        {
            IList<Product> products;
            products = _productRepository.GetAllProducts();
            
            return products;
        }
    }
}
