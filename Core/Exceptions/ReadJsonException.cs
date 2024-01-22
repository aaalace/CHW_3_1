namespace Core.Exceptions;

public class ReadJsonException : Exception
{
    public ReadJsonException() : base("Error while reading json") {}
}