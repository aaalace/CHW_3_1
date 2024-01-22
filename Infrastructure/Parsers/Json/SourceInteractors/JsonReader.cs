using Core.Exceptions;
using Infrastructure.Parsers.Json.Handlers;
using UI;

namespace Infrastructure.Parsers.Json.SourceInteractors;

public static class JsonReader
{
    public static List<string> ReadFromConsole()
    {
        var lines = new List<string>();
        
        ConsoleWrapper.WriteLine("Enter /stop to stop placing lines of data");

        string? line = ConsoleWrapper.ReadLine();
        while (line != "/stop")
        {
            if (line is not null) lines.Add(line.Trim());
            line = ConsoleWrapper.ReadLine();
        }
        
        return lines;
    }

    public static List<string> ReadFromFile(ref string initPath)
    {
        if (initPath == string.Empty) throw new EmptyPathException();
        var lines = new List<string>();
        
        ConsoleWrapper.WriteLine("Enter file path:");
        var filePath = FilePathHandler.Get();
        initPath = filePath;

        var oldReader = Console.In;
        var reader = new StreamReader(filePath);
        Console.SetIn(reader);
        
        while (true)
        {
            string? line = Console.ReadLine();
            if (line is null) break;
            
            lines.Add(line.Trim());
        }
        
        Console.SetIn(oldReader);
        
        reader.Dispose();
        
        return lines;
    }   
}