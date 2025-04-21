namespace lab04.Domain;

public class RemoteControl(IDevice device)
{
    public void TogglePower()
    {
        if (device.IsOn)
        {
            device.PowerOff();
        }
        else
        {
            device.PowerOn();
        }
    }
}