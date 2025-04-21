using lab05.Entities;

namespace lab05;

public static class DatabaseHelpers
{
    private static readonly Bogus.Faker Faker = new();
    
    public static async Task SeedAsync(this LabContext db)
    {
        if (!db.Tasks.Any())
        {
            db.Tasks.AddRange(
                Enumerable.Range(0, Faker.Random.Int(3, 10))
                    .Select(_ => new TaskItem
                    {
                        Title = Faker.Lorem.Sentence(),
                        Description = Faker.Lorem.Sentence(),
                        Status = Faker.PickRandom<TaskItemStatus>(),
                        CreatedAt = Faker.Date.Past().ToUniversalTime()
                    })
            );
            await db.SaveChangesAsync();
        }
    }
}