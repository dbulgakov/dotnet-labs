namespace lab04.Domain;

public class Television : IDevice
{
    public bool IsOn { get; private set; }
    public void PowerOn() { IsOn = true; Logger.Instance.Log("TV is ON"); }
    public void PowerOff() { IsOn = false; Logger.Instance.Log("TV is OFF"); }
}