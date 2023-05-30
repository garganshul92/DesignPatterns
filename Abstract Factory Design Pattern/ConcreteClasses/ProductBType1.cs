using Abstract_Factory_Design_Pattern.Interfaces;

namespace Abstract_Factory_Design_Pattern.ConcreteClasses
{
    public class ProductBType1 : IProduct
    {
        public void GetProductDetails()
        {
            Console.WriteLine("Hey! I am Product B of Type 1");
        }
    }
}
