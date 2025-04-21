namespace lab04;

class Logger
{
    private readonly List<string> _log = new();
    private Logger() { }

    public static Logger Instance { get; } = new Logger();

    public void Log(string message)
        => _log.Add($"[{DateTime.Now:HH:mm:ss.fff}] {message}");

    public void ShowLog()
    {
        Console.WriteLine("\n=== Log ===");
        foreach (var line in _log)
            Console.WriteLine(line);
    }
}


