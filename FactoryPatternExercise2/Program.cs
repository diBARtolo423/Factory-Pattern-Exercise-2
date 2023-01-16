namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database do you want to use? A List, SQL, or Mongo?");
            var userData = Console.ReadLine();

            IDataAccess data = DataAccessFactory.GetDataAccessType(userData);
            data.LoadData();
            data.SaveData();
        }
    }
}
