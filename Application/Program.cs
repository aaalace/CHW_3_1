using Application.Utils.Handlers.Common;
using UI;

namespace Application;

public static class Program
{
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