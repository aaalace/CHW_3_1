namespace Application.Utils.UI;

public static class ConsoleWrapper
{
    public static void WriteLine(string value, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(value);
        Console.ResetColor();
    }
}