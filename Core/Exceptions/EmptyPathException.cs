namespace Core.Exceptions;

public class EmptyPathException : Exception
{
    public EmptyPathException() : base("Empty path") {}
}