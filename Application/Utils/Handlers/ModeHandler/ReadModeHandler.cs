using Core.Enums;
using UI;

namespace Application.Utils.Handlers.ModeHandler;

public static class ReadModeHandler
{
    public static ReadMode Get()
    {
        ConsoleWrapper.WriteLine("console | file");
        var s = ConsoleWrapper.ReadLine();
        if (s is null) throw new ArgumentNullException();
        
        return s switch
        {
            "console" => ReadMode.Console,
            "file" => ReadMode.File,
            _ => throw new Exception()
        };
    }
}