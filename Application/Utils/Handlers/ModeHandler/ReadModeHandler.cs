using Application.Utils.UI;
using Core.Enums;

namespace Application.Utils.Handlers.ModeHandler;

public static class ReadModeHandler
{
    public static ReadMode Get()
    {
        try
        {
            // TODO
            return ReadMode.Console;
        }
        catch (Exception e)
        {
            ConsoleWrapper.WriteLine(e.Message);
            throw;
        }
    }
}