using Core.Enums;
using UI;
using Core.Exceptions;

namespace Application.Utils.Handlers.ModeHandler;

public static class ReadModeHandler
{
    /// <summary>
    /// Returns enum option of user's choice.
    /// </summary>
    public static ReadMode Get()
    {
        ConsoleWrapper.WriteLine("console | file");
        var s = ConsoleWrapper.ReadLine();
        if (s is null) throw new ArgumentNullException();
        
        return s switch
        {
            "console" => ReadMode.Console,
            "file" => ReadMode.File,
            _ => throw new ReadModeException()
        };
    }
}