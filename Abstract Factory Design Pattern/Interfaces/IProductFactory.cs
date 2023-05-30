namespace Abstract_Factory_Design_Pattern.Interfaces
{
    public interface IProductFactory
    {
        public IProduct GetProduct(char type);
    }
}
