using Core.Models;

namespace Infrastructure.Parsers.Json.Converters;

public static class JsonSerializer
{
    private const char q = '"';

    /// <summary>
    /// List of Customer objects converted to list of lines to be written to file.
    /// </summary>
    public static List<string> Serialize(List<Customer> customers)
    {
        var lines = new List<string>();
        
        lines.Add("[");

        for (int i = 0; i < customers.Count; i++)
        {
            var customer = customers[i];
            
            lines.Add("\t{");
            
            lines.Add($"\t\t{q}customer_id{q}: {customer.id},");
            
            lines.Add($"\t\t{q}name{q}: {q}{customer.name}{q},");
            
            lines.Add($"\t\t{q}email{q}: {q}{customer.email}{q},");
            
            lines.Add($"\t\t{q}age{q}: {customer.age},");
            
            lines.Add($"\t\t{q}city{q}: {q}{customer.city}{q},");
            
            lines.Add($"\t\t{q}is_premium{q}: {customer.isPremium.ToString().ToLower()},");
            
            lines.Add($"\t\t{q}purchases{q}: [");
            for (int j = 0; j < customer.purchases.Count; j++)
            {
                var purchase = customer.purchases.ElementAt(j);
                
                if (j == customer.purchases.Count - 1)
                {
                    lines.Add($"\t\t\t{q}{purchase}{q}");
                    break;
                }
                lines.Add($"\t\t\t{q}{purchase}{q},");
            }
            lines.Add($"\t\t]");
            
            if (i == customers.Count - 1)
            {
                lines.Add("\t}");
                break;
            }
            lines.Add("\t},");
        }

        lines.Add("]");
        return lines;
    }
}