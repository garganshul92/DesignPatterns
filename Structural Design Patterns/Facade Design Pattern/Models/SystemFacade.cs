namespace Facade_Design_Pattern.Models;

public class SystemFacade
{
    private SubSystemA _subSystemA;
    private SubSystemB _subSystemB;
    private SubSystemC _subSystemC;

    public SystemFacade()
    {
        _subSystemA = new SubSystemA();
        _subSystemB = new SubSystemB();
        _subSystemC = new SubSystemC();
    }

    public void OperationA1()
    {
        _subSystemA.OperationA1();
    }

    public void OperationA2()
    {
        _subSystemA.OperationA2();
    }

    public void OperationB1()
    {
        _subSystemB.OperationB1();
    }

    public void OperationB2()
    {
        _subSystemB.OperationB2();
    }

    public void OperationC1()
    {
        _subSystemC.OperationC1();
    }

    public void OperationC2()
    {
        _subSystemC.OperationC2();
    }
}
