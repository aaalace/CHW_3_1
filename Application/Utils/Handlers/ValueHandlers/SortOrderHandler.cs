using Core.Enums;
using UI;
using Core.Exceptions;

namespace Application.Utils.Handlers.ValueHandlers;

public static class SortOrderHandler
{
    public static SortOrder Get(FormatMode mode)
    {
        switch (mode)
        {
            case FormatMode.Id:
            case FormatMode.Age:
            case FormatMode.PurchasesAmount:
                ConsoleWrapper.WriteLine("increase | decrease");
                break;
            case FormatMode.Name:
            case FormatMode.Email:
            case FormatMode.City:
                ConsoleWrapper.WriteLine("az | za");
                break;
            case FormatMode.IsPremium:
                ConsoleWrapper.WriteLine("true first | false first");
                break;
        }

        return OrderHelper();
    }

    private static SortOrder OrderHelper()
    {
        string? s = ConsoleWrapper.ReadLine();
        if (s is null) throw new ArgumentNullException();

        return s switch
        {
            "increase" => SortOrder.Increase,
            "decrease" => SortOrder.Decrease,
            "az" => SortOrder.AZ,
            "za" => SortOrder.ZA,
            "true first" => SortOrder.TrueFirst,
            "false first" => SortOrder.FalseFirst,
            _ => throw new SortOrderException()
        };
    }
}