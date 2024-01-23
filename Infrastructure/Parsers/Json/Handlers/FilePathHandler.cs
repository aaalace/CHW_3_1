using UI;

namespace Infrastructure.Parsers.Json.Handlers;

public static class FilePathHandler
{
    /// <summary>
    /// Gets new path where to save data after formatting. 
    /// </summary>
    /// <returns>New path.</returns>
    public static string Get()
    {
        string? s = ConsoleWrapper.ReadLine();
        if (s is null) throw new ArgumentNullException();

        return s;
    }
}