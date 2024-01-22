using Application.Data;
using Application.Utils.Formatters;
using Application.Utils.Handlers.ModeHandler;
using Application.Utils.Handlers.ValueHandlers;
using Infrastructure.Parsers.Json;
using UI;

namespace Application.Services;

public class CustomerCollectionService : IDisposable
{
    private readonly CustomerCollection _collection = new();
    private string _initPath = string.Empty;
    
    public void ReadService()
    {
        ConsoleWrapper.WriteLine("Choose read mode:");
        var mode = ReadModeHandler.Get();
        
        _collection.Data = JsonParser.ReadJson(mode, ref _initPath);
        
        DataShower.Show(_collection.Data);
    }
    
    public void FilterService()
    {
        ConsoleWrapper.WriteLine("Choose filter field:");
        var mode = FormatModeHandler.Get();
        
        ConsoleWrapper.WriteLine("Enter filter value:");
        var value = FilterValueHandler.Get();

        _collection.Data = FilterWS.Filter(_collection, mode, value);
        
        DataShower.Show(_collection.Data);
    }
    
    public void SortService()
    {
        ConsoleWrapper.WriteLine("Choose sort field:");
        var mode = FormatModeHandler.Get();
        
        ConsoleWrapper.WriteLine("Choose sort order:");
        var order = SortOrderHandler.Get(mode);

        _collection.Data = SortWS.Sort(_collection, mode, order);
        
        DataShower.Show(_collection.Data);
    }
    
    public void WriteService()
    {
        ConsoleWrapper.WriteLine("Choose write mode:");
        var mode = WriteModeHandler.Get();
        
        JsonParser.WriteJson(_collection.Data, mode, _initPath);
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