using Application.Controllers;
using Application.Utils.Handlers.MenuHandler;
using UI;
using Core.Enums;

namespace Application;

public static class Starter
{
    /// <summary>
    /// Runs new program cycle with new file (creates new controller -> service -> collection).
    /// </summary>
    public static void Run()
    {
        var _controller = new CustomerCollectionController();
        
        bool firstLaunch = true;
        while (true)
        {
            try
            {
                if (firstLaunch)
                {
                    _controller.Run(MenuOption.Read);
                    firstLaunch = false;
                    continue;
                }   
                
                ConsoleWrapper.WriteLine("Choose menu option:");
                ConsoleWrapper.WriteLine("read | filter | sort | write | exit");
                
                var menuOption = MenuOptionHandler.Get();
                if (menuOption == MenuOption.Exit) break;
            
                _controller.Run(menuOption);
            }
            catch (Exception e)
            {
                ConsoleWrapper.WriteException(e);
            }
        }
    }   
}