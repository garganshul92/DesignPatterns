using Proxy_Design_Pattern.Interfaces;

namespace Proxy_Design_Pattern.Models;

public class RealInternet : IInternet
{
    public void ConnectTo(string url)
    {
        Console.WriteLine($"Conntected to URL: {url}");
    }
}
