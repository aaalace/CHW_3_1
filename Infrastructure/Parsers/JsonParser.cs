using Core.Enums;
using Infrastructure.Models;
using UI;

namespace Infrastructure.Parsers;

public static class JsonParser
{
    public static List<Customer> ReadJson(ReadMode mode)
    {
        try
        {
            // TODO: ONLY reads and returns collection
            return new List<Customer>();
        }
        catch (Exception e)
        {
            ConsoleWrapper.WriteException(e);
            throw;
        }
    }

    public static void WriteJson(WriteMode mode, List<Customer> customerCollection)
    {
        try
        {
            // TODO: ONLY writes collection
        }
        catch (Exception e)
        {
            ConsoleWrapper.WriteException(e);
            throw;
        }
    }
}