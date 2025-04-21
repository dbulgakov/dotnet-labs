using lab05.Entities;

namespace lab05;

public static class ConsoleHelpers
{
    public static void Log(string message) =>
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] {message}");

    public static void PrintTasks(IEnumerable<TaskItem> tasks)
    {
        const int idWidth = 36;
        const int titleWidth = 24;
        const int statusWidth = 12;
        const int dateWidth = 19;

        Console.WriteLine(
            $"{Pad("Id", idWidth)} | {Pad("Title", titleWidth)} | {Pad("Status", statusWidth)} | CreatedAt"
        );

        Console.WriteLine(new string('-', idWidth + titleWidth + statusWidth + dateWidth + 9));

        foreach (var task in tasks)
        {
            Console.WriteLine(
                $"{Pad(task.Id.ToString(), idWidth)} | " +
                $"{Pad(task.Title ?? string.Empty, titleWidth)} | " +
                $"{Pad(task.Status.ToString(), statusWidth)} | " +
                $"{task.CreatedAt:yyyy-MM-dd HH:mm:ss}"
            );
        }

        Console.WriteLine();
        return;

        string Pad(string value, int width) =>
            Crop(value, width).PadRight(width);

        string Crop(string value, int maxLength) =>
            value.Length <= maxLength ? value : value[..(maxLength - 1)] + "…";
    }
}
