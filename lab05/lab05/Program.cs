using lab05;
using lab05.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<LabContext>(opt =>
    opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

using var host = builder.Build();

await using var scope = host.Services.CreateAsyncScope();
var db = scope.ServiceProvider.GetRequiredService<LabContext>();

await db.Database.MigrateAsync();
await db.SeedAsync();

ConsoleHelpers.Log("Pre-existing Tasks:");
var allTasks = await db.Tasks.ToListAsync();
ConsoleHelpers.PrintTasks(allTasks);

ConsoleHelpers.Log("Filtered Tasks: InProgress");
var inProgressTasks = await db.Tasks
    .Where(t => t.Status == TaskItemStatus.InProgress)
    .ToListAsync();
ConsoleHelpers.PrintTasks(inProgressTasks);

if (allTasks.Count != 0)
{
    var task = await db.Tasks.OrderBy(x => x.Id).FirstAsync();
    task.Status = TaskItemStatus.Completed;
    await db.SaveChangesAsync();
    ConsoleHelpers.Log($"Updated Task: {task.Id} → Status = {task.Status}");
}

if (allTasks.Count > 1)
{
    var toDelete = await db.Tasks.FindAsync(allTasks.Last().Id);
    if (toDelete is not null)
    {
        db.Tasks.Remove(toDelete);
        await db.SaveChangesAsync();
        ConsoleHelpers.Log($"Deleted Task: {toDelete.Id}");
    }
}

ConsoleHelpers.Log("Final Tasks:");
var finalTasks = await db.Tasks.ToListAsync();
ConsoleHelpers.PrintTasks(finalTasks);

ConsoleHelpers.Log("Program finished. Press any key to exit.");
Console.ReadKey();