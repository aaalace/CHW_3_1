using UI;

namespace Application.Utils.Handlers.Common;

public static class ContinueRunAppHandler
{
    public static bool Check() => ConsoleWrapper.GetKey() != ConsoleKey.Q;
}