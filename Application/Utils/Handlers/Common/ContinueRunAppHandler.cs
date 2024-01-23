using UI;

namespace Application.Utils.Handlers.Common;

public static class ContinueRunAppHandler
{
    /// <summary>
    /// Checks if user wants to exit program.
    /// </summary>
    public static bool Check() => ConsoleWrapper.GetKey() != ConsoleKey.Q;
}