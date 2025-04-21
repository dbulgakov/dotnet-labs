namespace lab04;

class Settings
{
    private readonly Dictionary<string, string> _values = new();
    private Settings() { }

    public static Settings Instance { get; } = new Settings();

    public string this[string key]
    {
        get => _values.GetValueOrDefault(key, "");
        set => _values[key] = value;
    }
}