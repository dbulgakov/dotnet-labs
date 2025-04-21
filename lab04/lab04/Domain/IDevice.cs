namespace lab04.Domain;

public interface IDevice
{
    bool IsOn { get; }
    void PowerOn();
    void PowerOff();
}