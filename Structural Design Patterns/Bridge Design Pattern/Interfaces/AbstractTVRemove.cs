namespace Bridge_Design_Pattern.Interfaces;

public abstract class AbstractTVRemove
{
    protected ILedTV ledTV;
    public abstract void SwitchOn();
    public abstract void SwitchOff();

}
