using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2;

internal class ListDataAccess : IDataAccess
{
    public string Name { get; set; } = "List";
    public List<Product> LoadData()
    {
        Console.WriteLine($"I am reading data from {Name}.");
        return new List<Product>();
    }

    public void SaveData()
    {
        Console.WriteLine($"I am saving data to a {Name} database.");
    }
}
