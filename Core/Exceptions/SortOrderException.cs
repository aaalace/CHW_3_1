namespace Core.Exceptions;

public class SortOrderException : Exception
{
    public SortOrderException() : base("Wrong sorting order") {}
}