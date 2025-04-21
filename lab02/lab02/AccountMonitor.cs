namespace lab02;

public sealed class AccountMonitor
{
    public static void OnBalanceChanged(int newBalance)
    {
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] [Monitor] New balance: {newBalance:C}");
    }
}