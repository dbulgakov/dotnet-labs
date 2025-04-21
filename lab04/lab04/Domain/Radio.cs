namespace lab04.Domain;

public class Radio : IDevice
{ 
    public bool IsOn { get; private set; } 
    public void PowerOn() { IsOn = true; Logger.Instance.Log("Radio is ON"); } 
    public void PowerOff() { IsOn = false; Logger.Instance.Log("Radio is OFF"); }
}