using Application.Data;
using Core.Enums;
using Core.Models;

namespace Application.Utils.Formatters;

public static class SortWS
{
    public static List<Customer> Sort(CustomerCollection collection, FormatMode mode, SortOrder order)
    {
        var _collection = mode switch
        {
            FormatMode.Id => collection.Data.OrderBy(customer => customer.id).ToList(),
            FormatMode.Name => collection.Data.OrderBy(customer => customer.name).ToList(),
            FormatMode.Age => collection.Data.OrderBy(customer => customer.age).ToList(),
            FormatMode.Email => collection.Data.OrderBy(customer => customer.email).ToList(),
            FormatMode.City => collection.Data.OrderBy(customer => customer.city).ToList(),
            FormatMode.IsPremium => collection.Data.OrderBy(customer => customer.isPremium ? 0 : 1).ToList(),
            FormatMode.PurchasesAmount => collection.Data.OrderBy(customer => customer.purchases.Count).ToList(),
            _ => throw new Exception()
        };
        
        if (order is SortOrder.ZA or SortOrder.Decrease or SortOrder.FalseFirst) _collection.Reverse();

        return _collection;
    }
}