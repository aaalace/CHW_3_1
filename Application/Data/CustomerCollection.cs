using Core.Models;

namespace Application.Data;

public class CustomerCollection : IDisposable
{
    public List<Customer> Data { get; set; } = new();
    
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    private void Dispose(bool disposing)
    {
        foreach (var customer in Data)
        {
            if (customer is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }
    }

    ~CustomerCollection()
    {
        Dispose();
    }
}