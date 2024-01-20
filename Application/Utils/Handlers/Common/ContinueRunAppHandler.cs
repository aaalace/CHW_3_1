namespace Application.Utils.Handlers.Common;

public static class ContinueRunAppHandler
{
    public static bool Check() => Console.ReadKey(true).Key != ConsoleKey.Q;
}