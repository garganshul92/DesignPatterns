using Abstract_Factory_Design_Pattern.Interfaces;

namespace Abstract_Factory_Design_Pattern.ConcreteClasses
{
    public class ProductAType2 : IProduct
    {
        public void GetProductDetails()
        {
            Console.WriteLine("Hey! I am Product A of Type 2");
        }
    }
}
