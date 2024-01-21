using Application.Services;
using Core.Enums;

namespace Application.Controllers;

public class CustomerCollectionController : IDisposable
{
    private readonly CustomerCollectionService _service = new();

    public void Run(MenuOption menuOption)
    {
        switch (menuOption)
        {
            case MenuOption.Read:
                _service.ReadService();
                break;
            case MenuOption.Filter:
                _service.FilterService();
                break;
            case MenuOption.Sort:
                _service.SortService();
                break;
            case MenuOption.Write:
                _service.WriteService();
                break;
            case MenuOption.Exit:
            default:
                break;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    
    private void Dispose(bool disposing)
    {
        if (disposing)
        {
            _service.Dispose();
        }
    }

    ~CustomerCollectionController()
    {
        Dispose();
    }
}