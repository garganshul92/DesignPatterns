namespace Visitor_Design_Pattern.Interfaces;

public interface IElement
{
    public void Accept(IVisitor visitor);
}
