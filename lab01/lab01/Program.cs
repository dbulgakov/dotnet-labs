Log("Program Started");

Log("Running Tasks One by One");
await RunOneByOneAsync();

Log("Running Tasks in Parallel");
await RunParallelAsync();

Log("Program Finished. Press any key to exit.");

Console.ReadKey();

void Log(string message) => Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] {message}");

async Task DoWorkAsync(string taskName, int taskNumber)
{
    Log($"{taskName} #{taskNumber} started...");

    var result = 0;
    var totalSteps = taskNumber * 20;

    for (var i = 1; i <= totalSteps; i++)
    {
        result += i * taskNumber;
        var progress = i * 100 / totalSteps;
        Log($"{taskName} #{taskNumber} is working... {progress,3}% done");
        await Task.Delay(100);
    }

    Log($"{taskName} #{taskNumber} finished. Result: {result}");
}

async Task RunOneByOneAsync()
{
    await DoWorkAsync("Task", 1);
    await DoWorkAsync("Task", 2);
    await DoWorkAsync("Task", 3);
}

async Task RunParallelAsync()
{
    var tasks = new List<Task>(3);

    for (var i = 0; i < 3; i++)
    {
        tasks.Add(DoWorkAsync("Parallel task", i + 1));
    }

    await Task.WhenAll(tasks);
}