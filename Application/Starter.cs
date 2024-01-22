﻿using Application.Controllers;
using Application.Utils.Handlers.MenuHandler;
using UI;
using Core.Enums;

namespace Application;

public static class Starter
{
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
                    firstLaunch = false;
                    _controller.Run(MenuOption.Read);
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