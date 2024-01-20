using Application.Utils.Handlers.Common;
using Application.Utils.UI;

namespace Application;

public static class Program
{
    
    // BUG: TRYCATCH!!!!!! (all exceptions are from Handlers or Parsers)
    // TODO: CustomExceptions
    public static void Main()
    {
        do
        {
            ConsoleWrapper.WriteLine("Program started");
            Starter.Run();
        } while (ContinueRunApp());
    }

    private static bool ContinueRunApp()
    {
        ConsoleWrapper.WriteLine("Press Q to stop program");
        return ContinueRunAppHandler.Check();
    }
}