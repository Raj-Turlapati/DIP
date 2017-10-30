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
            IProductContext productContext = new ProductContext();
            IProductRepository productRepository = new ProductRepository(productContext);
            ProductService productService = new ProductService(productRepository);
            IList<Product> products = productService.GetAllProducts();

            Console.WriteLine("Number of products in store {0} \n", products.Count);

            foreach (Product product in products)
            {
                Console.WriteLine("Meal: {0}, Name: {1}, Price: Rs.{2}, Calories: {3}", product.Category.Name, product.Name, product.Price, product.Calories);

            }
            Console.Read();
        }
    }
}
