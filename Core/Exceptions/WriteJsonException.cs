namespace Core.Exceptions;

public class WriteJsonException : Exception
{
    public WriteJsonException() : base("Error while writing json") {}
}