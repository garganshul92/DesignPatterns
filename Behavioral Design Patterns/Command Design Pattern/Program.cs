using Command_Design_Pattern.Interfaces;
using Command_Design_Pattern.Models;

namespace Command_Design_Pattern;

class Program
{
    public static void Main(string[] args)
    {
        Product product = new Product("NewProduct", 10000);
        IInvoker modifyPrice = new ModifyPrice();
        Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 1000));
        Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Decrease, 2000));
        Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 3000));

        modifyPrice.UndoActions();
    }

    private static void Execute(Product product, IInvoker modifyPrice, ICommand command)
    {
        modifyPrice.SetCommand(command);
        modifyPrice.Invoke();
    }
}


