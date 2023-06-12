using Bridge_Design_Pattern.Interfaces;
using Bridge_Design_Pattern.Models;

AbstractTVRemove sonyTVRemote = new SonyTVRemote(new SonyLedTV());
AbstractTVRemove samsungTVRemote = new SamsungTVRemote(new SamsungLedTV());

sonyTVRemote.SwitchOn();
sonyTVRemote.SwitchOff();

Console.WriteLine("-----------------------");

samsungTVRemote.SwitchOn();
samsungTVRemote.SwitchOff();