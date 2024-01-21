using Application.Controllers;
using Application.Utils.Handlers.MenuHandler;
using UI;
using Core.Enums;
using Core.Exceptions;

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

            MenuOption menuOption;
            try
            {
                menuOption = MenuOptionHandler.Get();
            }
            catch (ArgumentNullException e)
            {
                ConsoleWrapper.WriteException(e);
                continue;
            }
            catch (MenuChoiceException e)
            {
                ConsoleWrapper.WriteException(e);
                continue;
            }
            
            if (menuOption == MenuOption.Exit) break;
            
            _controller.Run(menuOption);
        }
    }
}