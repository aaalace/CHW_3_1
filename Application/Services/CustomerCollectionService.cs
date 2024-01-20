using Application.Utils.Handlers.ModeHandler;
using Application.Utils.UI;
using Application.Data;
using Infrastructure.Parsers;

namespace Application.Services;

public class CustomerCollectionService : IDisposable
{
    private readonly CustomerCollection _collection = new();
    
    public void Read()
    {
        ConsoleWrapper.WriteLine("Choose read mode");
        var mode = ReadModeHandler.Get();
        
        _collection.Data = JsonParser.ReadJson(mode);
    }
    
    public void Filter()
    {
        ConsoleWrapper.WriteLine("Choose filter mode");
        var mode = FormatModeHandler.Get();
        // TODO: FilterValueHandler.Get(mode) <=> value depends on mode
        
        // TODO: normal filtering
        _collection.Data = _collection.Data.Where(customer => customer.id == 1).ToList();
    }
    
    public void Sort()
    {
        ConsoleWrapper.WriteLine("Choose sort mode");
        var mode = FormatModeHandler.Get();
        // TODO: SortValueHandler.Get(mode) <=> value depends on mode (int - inc/dec; str - alph order)
        
        // TODO: normal sorting
        _collection.Data = _collection.Data.OrderBy(customer => customer.id).ToList();
    }
    
    public void Write()
    {
        ConsoleWrapper.WriteLine("Choose write mode");
        var mode = WriteModeHandler.Get();
        
        JsonParser.WriteJson(mode, _collection.Data);
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
            _collection.Dispose();
        }
    }

    ~CustomerCollectionService()
    {
        Dispose();
    }
}