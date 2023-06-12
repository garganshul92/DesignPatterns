using Bridge_Design_Pattern.Interfaces;

namespace Bridge_Design_Pattern.Models;

public class SamsungTVRemote : AbstractTVRemove
{
    public SamsungTVRemote(ILedTV tv)
    {
        ledTV = tv;
    }
    public override void SwitchOff()
    {
        ledTV.SwitchOff();
    }

    public override void SwitchOn()
    {
        ledTV.SwitchOn();
    }
}
