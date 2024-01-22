using Infrastructure.Parsers.Json.Handlers;

namespace Infrastructure.Parsers.Json.SourceInteractors;

public static class JsonReader
{
    public static List<string> ReadFromConsole()
    {
        var lines = new List<string>();
        
        
        
        return lines;
    }

    public static List<string> ReadFromFile()
    {
        var lines = new List<string>();

        var filePath = FilePathHandler.Get();
        
        using var reader = new StreamReader(filePath);
        Console.SetIn(reader);
        while (Console.ReadLine() is { } line)
        {
            string newLine = line.Replace("".PadRight(4, ' '), "\t");
            lines.Add(newLine);
        }
        
        return lines;
    }
}