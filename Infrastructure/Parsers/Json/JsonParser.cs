using Core.Enums;
using Infrastructure.Models;
using Infrastructure.Parsers.Json.Converters;
using Infrastructure.Parsers.Json.SourceInteractors;
using UI;

namespace Infrastructure.Parsers.Json;

public static class JsonParser
{
    public static List<Customer> ReadJson(ReadMode mode)
    {
        var lines = mode switch
        {
            ReadMode.Console => JsonReader.ReadFromConsole(),
            ReadMode.File => JsonReader.ReadFromFile(),
            _ => new List<string>()
        };

        var customerCollection = JsonDeserializer.Deserialize(lines);
        
        return customerCollection;
    }

    public static void WriteJson(WriteMode mode, List<Customer> customerCollection)
    {
        var lines = JsonSerializer.Serialize(customerCollection);

        switch (mode)
        {
            case WriteMode.Rewrite:
                JsonWriter.Rewrite(lines);
                break;
            case WriteMode.NewFile:
                JsonWriter.WriteNewFile(lines);
                break;
        }
        
        ConsoleWrapper.WriteLine("Data saved");
    }
}