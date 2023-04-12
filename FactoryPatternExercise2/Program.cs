namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to use a List, SQL, or Mongo?");
            string databaseType = Console.ReadLine();

            var caseType = DataAccessFactory.GetDataAccessType(databaseType);

            caseType.LoadData();

            caseType.SaveData();
        }
    }
}
