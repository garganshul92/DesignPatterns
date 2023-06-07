using Abstract_Factory_Design_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern.ConcreteClasses
{
    public class ProductAFactory : IProductFactory
    {
        public IProduct GetProduct(char type)
        {
            switch (type)
            {
                case '1':
                    {
                        return new ProductAType1();
                    }
                case '2':
                    {
                        return new ProductAType2();
                    }
            }

            throw new NotImplementedException("Product not available for the given type");
        }
    }
}
