
namespace Abstract_Factory_Design_Pattern.Interfaces
{
    public interface IProductAbstractFactory
    {
        public IProductFactory GetProductFactory(char type);
    }
}
