using Interface;
using Models;

namespace Factory_Design_Pattern.Factory;

public static class ProductFactory
{
    public static IProduct GetProduct(char type)
    {
        IProduct product = null;

        switch (type)
        {
            case 'A':
                {
                    product = new ProductA();
                    break;
                }
            case 'B':
                {
                    product = new ProductB();
                    break;
                }
            case 'C':
                {
                    product = new ProductC();
                    break;
                }
        }

        return product;
    }

}
