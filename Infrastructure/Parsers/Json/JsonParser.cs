using Core.Enums;
using Core.Models;
using Infrastructure.Parsers.Json.Converters;
using Infrastructure.Parsers.Json.SourceInteractors;
using UI;

namespace Infrastructure.Parsers.Json;

public static class JsonParser
{
    /// <summary>
    /// Calls variants of reading data.
    /// </summary>
    /// <param name="mode">Mode of reading data.</param>
    /// <param name="initPath">Path which was opened by user at start of new program cycle</param>
    /// <returns></returns>
    public static List<Customer> ReadJson(ReadMode mode, ref string initPath)
    {
        var lines = mode switch
        {
            ReadMode.Console => JsonReader.ReadFromConsole(),
            ReadMode.File => JsonReader.ReadFromFile(ref initPath),
            _ => new List<string>()
        };

        var customerCollection = JsonDeserializer.Deserialize(lines);
        
        return customerCollection;
    }

    /// <summary>
    /// Calls variants of saving data.
    /// </summary>
    /// <param name="customerCollection">Collection to save in json format.</param>
    /// <param name="mode">Mode of saving data.</param>
    /// <param name="initPath">Path which was opened by user at start of new program cycle</param>
    public static void WriteJson(List<Customer> customerCollection, WriteMode mode, in string initPath)
    {
        var lines = JsonSerializer.Serialize(customerCollection);

        switch (mode)
        {
            case WriteMode.Rewrite:
                JsonWriter.Rewrite(lines, in initPath);
                break;
            case WriteMode.NewFile:
                JsonWriter.WriteNewFile(lines);
                break;
        }
        
        ConsoleWrapper.WriteLine("Data saved", ConsoleColor.Green);
    }
}