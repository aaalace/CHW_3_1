using Application.Data;
using Core.Enums;
using Core.Models;

namespace Application.Utils.Formatters;

public static class FilterWS
{
    /// <summary>
    /// Filters collection by mode and value.
    /// </summary>
    /// <param name="collection">Collection to be filtered.</param>
    /// <param name="mode">Field of filtering.</param>
    /// <param name="value">Value to filter by.</param>
    /// <returns>Filtered collection.</returns>
    public static List<Customer> Filter(CustomerCollection collection, FormatMode mode, string value)
    {
        return mode switch
        {
            FormatMode.Id => collection.Data.Where(customer => customer.id.ToString() == value).ToList(),
            FormatMode.Name => collection.Data.Where(customer => customer.name.ToString() == value).ToList(),
            FormatMode.Age => collection.Data.Where(customer => customer.age.ToString() == value).ToList(),
            FormatMode.Email => collection.Data.Where(customer => customer.email.ToString() == value).ToList(),
            FormatMode.City => collection.Data.Where(customer => customer.city.ToString() == value).ToList(),
            FormatMode.IsPremium => collection.Data.Where(customer => customer.isPremium.ToString().ToLower() == value).ToList(),
            FormatMode.PurchasesAmount => collection.Data.Where(customer => customer.purchases.Count.ToString() == value).ToList(),
            _ => throw new Exception()
        };
    }
}