using Core.Enums;
using Infrastructure.Models;
using UI;

namespace Infrastructure.Parsers;

public static class JsonParser
{
    public static List<Customer> ReadJson(ReadMode mode)
    {
        ConsoleWrapper.WriteLine($"reading json with mode: {mode}");

        var c1 = new Customer(
            1, 
            "a",
            "b@m",
            6,
            "kazan", 
            true,
            new List<string> {"a", "a", "a"}
            );
        
        var c2 = new Customer(
            2, 
            "c",
            "b@m",
            9,
            "abakan", 
            false,
            new List<string> {"a", "a"}
        );
        
        var c3 = new Customer(
            3, 
            "b",
            "c@m",
            67,
            "belgrad", 
            true,
            new List<string> {"a", "a", "a", "a", "a"}
        );
        
        return new List<Customer> {c1, c2, c3};
    }

    public static void WriteJson(WriteMode mode, List<Customer> customerCollection)
    {
        ConsoleWrapper.WriteLine($"writing json with mode: {mode}");
    }
}