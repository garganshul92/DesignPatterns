using Abstract_Factory_Design_Pattern.Interfaces;

namespace Abstract_Factory_Design_Pattern.ConcreteClasses
{
    public class ProductBFactory : IProductFactory
    {
        public IProduct GetProduct(char type)
        {
            switch (type)
            {
                case '1':
                    {
                        return new ProductBType1();
                    }
                case '2':
                    {
                        return new ProductBType2();
                    }
            }

            throw new NotImplementedException("Product not available for the given type");
        }
    }
}
