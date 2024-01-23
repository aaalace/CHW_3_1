using UI;
using Core.Enums;
using Core.Exceptions;

namespace Application.Utils.Handlers.MenuHandler;

public static class MenuOptionHandler
{
    /// <summary>
    /// Returns enum option of user's choice.
    /// </summary>
    public static MenuOption Get()
    {
        var s = ConsoleWrapper.ReadLine();
        if (s is null) throw new ArgumentNullException();
        
        return s switch
        {
            "read" => MenuOption.Read,
            "filter" => MenuOption.Filter,
            "sort" => MenuOption.Sort,
            "write" => MenuOption.Write,
            "exit" => MenuOption.Exit,
            _ => throw new MenuChoiceException()
        };
    }
}