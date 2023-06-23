using Proxy_Design_Pattern.Interfaces;
using Proxy_Design_Pattern.Models;

IInternet internet = new ForwardProxyInternet();
internet.ConnectTo("https://abc.com");
internet.ConnectTo("https://def.com");
internet.ConnectTo("https://xyz.com");
internet.ConnectTo("https://virus.com");
internet.ConnectTo("https://spam.com");