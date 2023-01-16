﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public SQLDataAccess()
        {
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQLDataAccess");
            return Product.ProductList;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to SQLDataAccess database");
        }
    }
}
