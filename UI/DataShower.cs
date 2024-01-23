using Core.Models;

namespace UI;

public static class DataShower
{
    public static void Show(List<Customer> customers)
    {
        if (customers.Count == 0) ConsoleWrapper.WriteLine("Empty", ConsoleColor.DarkYellow);
        
        foreach (var customer in customers)
        {
            if (customer.id == customers[0].id)
            {
                ConsoleWrapper.WriteLine("|------------------------------", ConsoleColor.DarkYellow);
            }
            else
            {
                ConsoleWrapper.WriteLine("|------------------------------");
            }
            
            ConsoleWrapper.WriteLine($"| ID: {customer.id}");
            ConsoleWrapper.WriteLine($"| NAME: {customer.name}");
            ConsoleWrapper.WriteLine($"| EMAIL: {customer.email}");
            ConsoleWrapper.WriteLine($"| AGE: {customer.age}");
            ConsoleWrapper.WriteLine($"| CITY: {customer.city}");
            ConsoleWrapper.WriteLine($"| IS PREMIUM: {customer.isPremium.ToString().ToLower()}");
            ConsoleWrapper.WriteLine("| PURCHASES:");
            for (int i = 0; i < customer.purchases.Count; i++)
            {
                ConsoleWrapper.WriteLine($"| {i + 1}) {customer.purchases[i]}");
            }

            if (customer.id == customers[^1].id)
            {
                ConsoleWrapper.WriteLine("|------------------------------", ConsoleColor.DarkYellow);
            }
        }
    }
}