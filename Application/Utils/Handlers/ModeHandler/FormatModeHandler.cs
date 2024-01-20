using Application.Utils.UI;
using Core.Enums;

namespace Application.Utils.Handlers.ModeHandler;

public static class FormatModeHandler
{
    public static FormatMode Get()
    {
        try
        {
            // TODO
            return FormatMode.Id;
        }
        catch (Exception e)
        {
            ConsoleWrapper.WriteLine(e.Message);
            throw;
        }
    }
}