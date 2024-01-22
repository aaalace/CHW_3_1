using Core.Exceptions;
using Core.Models;

namespace Infrastructure.Parsers.Json.Converters;

public static class JsonDeserializer
{
    public static List<Customer> Deserialize(List<string> lines)
    {
        var customers = new List<Customer>();
        
        if (lines[0] != "[") throw new WrongJsonFormat();
        if (lines[^1] != "]") throw new WrongJsonFormat();
        
        for (int i = 1; i < lines.Count - 1; i++)
        {
            var line = lines[i];

            if (line != "{") continue;
            
            int id = 0;
            string name = string.Empty;
            string email = string.Empty;
            int age = 0;
            string city = string.Empty;
            bool isPremium = false;
            List<string> purchases = new();
                
            while (true)
            {
                line = lines[++i];
                if (line is "}," or "}") break;
                
                if (line.Contains("customer_id"))
                {
                    if (!int.TryParse(line.Split(": ").ToArray()[1].TrimEnd(','), out id))
                    {
                        throw new WrongJsonFormat();
                    }
                    continue;
                }
                if (line.Contains("name"))
                {
                    name = line.Split(": ").ToArray()[1].TrimEnd(',').Trim('"');
                    continue;
                }
                if (line.Contains("email"))
                {
                    email = line.Split(": ").ToArray()[1].TrimEnd(',').Trim('"');
                    continue;
                }
                if (line.Contains("age"))
                {
                    if (!int.TryParse(line.Split(": ").ToArray()[1].TrimEnd(','), out age))
                    {
                        throw new WrongJsonFormat();
                    }
                    continue;
                }
                if (line.Contains("city"))
                {
                    city = line.Split(": ").ToArray()[1].TrimEnd(',').Trim('"');
                    continue;
                }
                if (line.Contains("is_premium"))
                {
                    string isPremiumAsString = line.Split(": ").ToArray()[1].TrimEnd(',');
                    isPremium = isPremiumAsString switch
                    {
                        "true" => true,
                        "false" => false,
                        _ => throw new WrongJsonFormat()
                    };
                    continue;
                }
                if (line.Contains("purchases"))
                {
                    while (true)
                    {
                        line = lines[++i];
                        
                        if (line == "]") break;
                    
                        string pcVal = line.TrimEnd(',').Trim('"');
                        purchases.Add(pcVal);
                    }
                    continue;
                }

                throw new WrongJsonFormat();
            }

            var customer = new Customer(id, name, email, age, city, isPremium, purchases);
            customers.Add(customer);
        }
        
        return customers;
    }
}