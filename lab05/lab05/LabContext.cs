using lab05.Entities;
using Microsoft.EntityFrameworkCore;

namespace lab05;

public class LabContext(DbContextOptions<LabContext> options) : DbContext(options)
{
    public DbSet<TaskItem> Tasks => Set<TaskItem>();
}