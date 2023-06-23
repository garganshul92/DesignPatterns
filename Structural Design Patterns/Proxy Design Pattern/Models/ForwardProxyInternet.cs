using Proxy_Design_Pattern.Interfaces;

namespace Proxy_Design_Pattern.Models;

public class ForwardProxyInternet : IInternet
{
    IInternet _realInternet;

    public ForwardProxyInternet()
    {
        _realInternet = new RealInternet();
    }

    public void ConnectTo(string url)
    {
        if(url.Contains("virus") || url.Contains("spam"))
        {
            Console.WriteLine($"The URL is not found.");
            return;
        }

        Console.WriteLine($"Conntecting to URL: {url}...");
        _realInternet.ConnectTo(url);
    }
}
