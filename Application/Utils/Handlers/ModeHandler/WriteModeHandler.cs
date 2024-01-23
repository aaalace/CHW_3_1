using UI;
using Core.Enums;
using Core.Exceptions;

namespace Application.Utils.Handlers.ModeHandler;

public static class WriteModeHandler
{
    /// <summary>
    /// Returns enum option of user's choice.
    /// </summary>
    public static WriteMode Get()
    {
        ConsoleWrapper.WriteLine("rewrite | new file");
        var s = ConsoleWrapper.ReadLine();
        if (s is null) throw new ArgumentNullException();
        
        return s switch
        {
            "rewrite" => WriteMode.Rewrite,
            "new file" => WriteMode.NewFile,
            _ => throw new WriteModeException()
        };
    }
}