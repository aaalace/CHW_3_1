﻿using Application.Data;
using Core.Enums;
using Infrastructure.Models;

namespace Application.Utils.Formatters;

public static class FilterWS
{
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