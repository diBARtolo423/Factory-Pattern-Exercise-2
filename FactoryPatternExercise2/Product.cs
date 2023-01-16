using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class Product
    {
        public Product()
        {
        }

        public string Name { get; set; }
        public int Price { get; set; }

        public static List<Product> ProductList = new List<Product>() 
        { 
            new Product() { Name = "Legos", Price = 100 }, 
            new Product() { Name = "Playdough", Price = 25 },
            new Product() { Name = "PS5", Price = 500 },
            new Product() { Name = "iPhone", Price = 600 },
        };

    }
}
