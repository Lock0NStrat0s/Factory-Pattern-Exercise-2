namespace FactoryPatternExercise2;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Select database to use (\"List\"(default), \"SQL\", or \"Mongo\"): ");
        IDataAccess dataAccess = DataAccessFactory.GetDataAccessType(Console.ReadLine());

        dataAccess.LoadData();
        dataAccess.SaveData();
    }
}
