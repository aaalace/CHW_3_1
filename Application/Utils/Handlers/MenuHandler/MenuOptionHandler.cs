using UI;
using Core.Enums;

namespace Application.Utils.Handlers.MenuHandler;

public static class MenuOptionHandler
{
    public static MenuOption Get()
    {
        // TODO
        var s = ConsoleWrapper.ReadLine();
        return s switch
        {
            "read" => MenuOption.Read,
            "filter" => MenuOption.Filter,
            "sort" => MenuOption.Sort,
            "write" => MenuOption.Write,
            "exit" => MenuOption.Exit,
            _ => throw new Exception()
        };
    }
}