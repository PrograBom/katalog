using KatalogLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatalogLibrary;

public class GlobalConfig
{
    public static SqlConnector? Connection { get; private set; } = InitConnection();

    private static SqlConnector? InitConnection()
    {
        try
        {
            return new SqlConnector();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Chyba pri inicializácii SqlConnector: {ex.Message}");
            return null;
        }
    }

    public static string? CnnString(string name)
    {
        try
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Chyba pri načítaní connection string: {ex.Message}");
            return null;
        }
    }
}

