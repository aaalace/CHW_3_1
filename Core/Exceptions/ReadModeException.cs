namespace Core.Exceptions;

public class ReadModeException : Exception
{
    public ReadModeException() : base("Wrong reading mode") {}
}