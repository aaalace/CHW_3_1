using UI;
using Core.Enums;
using Core.Exceptions;

namespace Application.Utils.Handlers.ModeHandler;

public static class FormatModeHandler
{
    /// <summary>
    /// Returns enum option of user's choice.
    /// </summary>
    public static FormatMode Get()
    {
        ConsoleWrapper.WriteLine("id | name | email | age | city | is premium | purchases amount");
        var s = ConsoleWrapper.ReadLine();
        if (s is null) throw new ArgumentNullException();
        
        return s switch
        {
            "id" => FormatMode.Id,
            "name" => FormatMode.Name,
            "age" => FormatMode.Age,
            "email" => FormatMode.Email,
            "city" => FormatMode.City,
            "is premium" => FormatMode.IsPremium,
            "purchases amount" => FormatMode.PurchasesAmount,
            _ => throw new FormatModeException()
        };
    }
}