using Application.Controllers;
using Application.Utils.Handlers.MenuHandler;
using Application.Utils.UI;
using Core.Enums;

namespace Application;

public static class Starter
{
    public static void Run()
    {
        var _controller = new CustomerCollectionController();
        
        while (true)
        {
            ConsoleWrapper.WriteLine("Choose menu option:");
            ConsoleWrapper.WriteLine("read | filter | sort | write | exit");
            var menuOption = MenuOptionHandler.Get();
            if (menuOption == MenuOption.Exit) break;
            
            _controller.Run(menuOption);
        }
    }
}