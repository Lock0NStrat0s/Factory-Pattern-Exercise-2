using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2;

internal static class DataAccessFactory
{
    public static IDataAccess GetDataAccessType(string databaseType)
    {
        switch (databaseType.ToLower())
        {
            case "mongo":
                return new MongoDataAccess();
            case "list":
                return new ListDataAccess();
            case "sql":
                return new SQLDataAccess();
            default:
                return new ListDataAccess();
        }
    }
}
