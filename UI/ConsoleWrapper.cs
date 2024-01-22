namespace UI;

public static class ConsoleWrapper
{
    public static ConsoleKey GetKey()
    {
        return Console.ReadKey(true).Key;
    }
    
    public static string? ReadLine()
    {
        Write("> ");
        return Console.ReadLine();
    }

    public static void Write(string s)
    {
        Console.Write(s);
    }
    
    public static void WriteLine(string value, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(value);
        Console.ResetColor();
    }

    public static void WriteException(Exception exception)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("<ERROR> " + exception.Message);
        Console.ResetColor();
    }
}