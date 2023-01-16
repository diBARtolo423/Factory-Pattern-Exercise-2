using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from MongoDataAccess");
            return Product.ProductList;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to MongoDataAccess database");
        }
    }
}
