using Abstract_Factory_Design_Pattern.Interfaces;

namespace Abstract_Factory_Design_Pattern.ConcreteClasses
{
    public class ProductAbstractFactory : IProductAbstractFactory
    {
        public IProductFactory GetProductFactory(char type)
        {
            switch(type)
            {
                case 'A':
                    {
                        return new ProductAFactory();
                    }
                case 'B':
                    {
                        return new ProductBFactory();
                    }
            }

            throw new NotImplementedException("Product type is not valid");
        }
    }
}
