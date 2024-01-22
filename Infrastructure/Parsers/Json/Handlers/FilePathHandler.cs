using UI;

namespace Infrastructure.Parsers.Json.Handlers;

public static class FilePathHandler
{
    public static string Get()
    {
        string? s = ConsoleWrapper.ReadLine();
        if (s is null) throw new Exception();

        return s;
    }
}