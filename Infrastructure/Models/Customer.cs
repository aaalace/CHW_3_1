namespace Infrastructure.Models;

public class Customer : IDisposable
{
    public readonly int id;
    public readonly string name;
    public readonly string email;
    public readonly int age;
    public readonly string city;
    public readonly bool isPremium;
    public readonly List<string> purchases;

    public Customer(int id, string name, string email, int age, string city, bool isPremium, List<string> purchases)
    {
        this.id = id;
        this.name = name;
        this.email = email;
        this.age = age;
        this.city = city;
        this.isPremium = isPremium;
        this.purchases = purchases;
    }
    
    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }

    ~Customer()
    {
        Dispose();
    }
}