using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using URHealth;

namespace URHealthClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService();
            IList<Product> products = productService.GetAllProducts();
            Console.WriteLine("Number of products in store {0}", products.Count);
            Console.WriteLine("Category || Product Name || Price || Calories");
            foreach (Product product in products)
            {
                Console.WriteLine("{0} || {1} || Rs.{2} || {3} ", product.Category.Name, product.Name, product.Price, product.Calories);               
                
            }

            Console.Read();
        }
    }
}
