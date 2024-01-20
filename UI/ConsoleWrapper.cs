namespace UI;

public static class ConsoleWrapper
{
    public static void WriteLine(string value, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(value);
        Console.ResetColor();
    }

    public static void WriteException(Exception exception)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR");
        Console.WriteLine(exception.Message);
        Console.ResetColor();
    }
}