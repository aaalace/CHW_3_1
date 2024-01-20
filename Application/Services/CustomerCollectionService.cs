﻿using Application.Utils.Handlers.ModeHandler;
using UI;
using Application.Data;
using Infrastructure.Parsers;

namespace Application.Services;

public class CustomerCollectionService : IDisposable
{
    private readonly CustomerCollection _collection = new();
    
    public void Read()
    {
        ConsoleWrapper.WriteLine("Choose read mode:");
        ConsoleWrapper.WriteLine("console | file");
        var mode = ReadModeHandler.Get();
        
        _collection.Data = JsonParser.ReadJson(mode);
    }
    
    public void Filter()
    {
        ConsoleWrapper.WriteLine("Choose filter field:");
        ConsoleWrapper.WriteLine("id | name | email | age | city | isPremium | purchases amount");
        var mode = FormatModeHandler.Get();
        
        ConsoleWrapper.WriteLine("Choose filter value:");
        // TODO: var value = FilterValueHandler.Get()
        
        // TODO: normal filtering by mode and value
        // _collection.Data = _collection.Data.Where(customer => customer.id == 1).ToList();
    }
    
    public void Sort()
    {
        ConsoleWrapper.WriteLine("Choose sort field:");
        ConsoleWrapper.WriteLine("id | name | email | age | city | isPremium | purchases amount");
        var mode = FormatModeHandler.Get();
        
        ConsoleWrapper.WriteLine("Choose sort order");
        // TODO: var order = SortOrderHandler.Get(mode)
        
        // TODO: normal sorting by mode and order
        // _collection.Data = _collection.Data.OrderBy(customer => customer.id).ToList();
    }
    
    public void Write()
    {
        ConsoleWrapper.WriteLine("Choose write mode:");
        ConsoleWrapper.WriteLine("rewrite | new file");
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