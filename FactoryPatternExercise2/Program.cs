namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database do you want to use? A List, SQL, or Mongo?");
            var userData = Console.ReadLine();

            IDataAccess data = DataAccessFactory.GetDataAccessType(userData);
            List<Product> ProductList = data.LoadData();
            data.SaveData();

            Console.WriteLine("Here are your items:");
            foreach (var item in ProductList)
            {
                Console.WriteLine($"Product Name: {item.Name}");
                Console.WriteLine($"Product Price: {item.Price}");
            }

            
        }
    }
}
