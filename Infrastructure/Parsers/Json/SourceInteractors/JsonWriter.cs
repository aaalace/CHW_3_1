using Infrastructure.Parsers.Json.Handlers;
using UI;

namespace Infrastructure.Parsers.Json.SourceInteractors;

public static class JsonWriter
{
    public static void Rewrite(List<string> lines, in string initPath)
    {
        var fileStream = new FileStream(initPath, FileMode.Open);
        fileStream.SetLength(0);
        fileStream.Dispose();
        
        Write(lines, initPath);
    }

    public static void WriteNewFile(List<string> lines)
    {
        ConsoleWrapper.WriteLine("Enter file path:");
        var newPath = FilePathHandler.Get();
        
        Write(lines, newPath);
    }

    private static void Write(List<string> lines, string path)
    {
        var oldWriter = Console.Out;
        var writer = new StreamWriter(path);
        Console.SetOut(writer);
        
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }
        
        Console.SetOut(oldWriter);
        
        writer.Dispose();
    }
}