namespace Core.Exceptions;

public class WriteModeException : Exception
{
    public WriteModeException() : base("Wrong writing mode") {}
}