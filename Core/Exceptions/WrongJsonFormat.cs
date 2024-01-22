namespace Core.Exceptions;

public class WrongJsonFormat : Exception
{
    public WrongJsonFormat() : base("Wrong json format") {}
}