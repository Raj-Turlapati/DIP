using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using URHealth.Service;
using URHealth.Model;
using URHealth.Repository;


namespace URHealth.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductContext dbContext = new ProductContext();
            IProductRepository productRepository = new ProductRepository(dbContext);
            ProductService productService = new ProductService(productRepository);
            IList<Product> products = productService.GetAllProducts();

            Console.WriteLine("Number of products in store {0}", products.Count);
            Console.WriteLine("***********************************************");
            Console.WriteLine("Category || Product Name || Price || Calories");
            Console.WriteLine("***********************************************");
            foreach (Product product in products)
            {
                Console.WriteLine("{0} || {1} || Rs.{2} || {3} ", product.Category.Name, product.Name, product.Price, product.Calories);

            }
            Console.Read();
        }
    }
}
