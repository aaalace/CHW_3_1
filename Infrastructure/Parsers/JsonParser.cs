using Core.Enums;
using Infrastructure.Models;

namespace Infrastructure.Parsers;

public static class JsonParser
{
    public static List<Customer> ReadJson(ReadMode mode)
    {
        Console.WriteLine("ReadJson");
        // TODO: ONLY reads and returns collection
        return new List<Customer>();
    }

    public static void WriteJson(WriteMode mode, List<Customer> customerCollection)
    {
        Console.WriteLine("WriteJson");
        // TODO: ONLY writes collection
    }
}