using Application.Utils.UI;
using Core.Enums;

namespace Application.Utils.Handlers.ModeHandler;

public static class WriteModeHandler
{
    public static WriteMode Get()
    {
        try
        {
            // TODO
            return WriteMode.Rewrite;
        }
        catch (Exception e)
        {
            ConsoleWrapper.WriteLine(e.Message);
            throw;
        }
    }
}