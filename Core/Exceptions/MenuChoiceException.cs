namespace Core.Exceptions;

public class MenuChoiceException : Exception
{
    public MenuChoiceException() : base("Wrong menu option") {}
}