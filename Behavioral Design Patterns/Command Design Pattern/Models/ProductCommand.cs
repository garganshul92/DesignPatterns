using Command_Design_Pattern.Interfaces;

namespace Command_Design_Pattern.Models;

// Concrete Command
public class ProductCommand : ICommand
{
    Product _product;
    PriceAction _priceAction;
    int _amount;

    public ProductCommand(Product product, PriceAction priceAction, int amount)
    {
        _product = product;
        _priceAction = priceAction;
        _amount = amount;
    }

    public void Execute()
    {
        if(_priceAction == PriceAction.Increase)
        {
            _product.IncreasePrice(_amount);
        }
        else
        {
            _product.DecreasePrice(_amount);
        }
    }

    public void Undo()
    {
        if(_priceAction == PriceAction.Increase)
        {
            _product.DecreasePrice(_amount);
        }
        else
        {
            _product.IncreasePrice(_amount);
        }

    }
}
