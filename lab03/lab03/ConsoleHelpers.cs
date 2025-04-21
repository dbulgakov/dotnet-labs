using System;

namespace lab03;

public static class ConsoleHelpers
{
    public static void Log(string message) => Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] {message}");
}