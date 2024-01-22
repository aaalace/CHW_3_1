using UI;

namespace Application.Utils.Handlers.ValueHandlers;

public static class FilterValueHandler
{
    public static string Get()
    {
        string? s = ConsoleWrapper.ReadLine();
        if (s is null) throw new ArgumentNullException();

        return s;
    }
}