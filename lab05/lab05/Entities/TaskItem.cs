using System.ComponentModel.DataAnnotations;

namespace lab05.Entities;

public class TaskItem
{
    public TaskItem(string? title = null, string? description = null)
    {
        Title = title ?? $"Task {Id}";
        Description = description;
    }
    
    public Guid Id { get; init; } = Guid.NewGuid();
    
    [MaxLength(256)]
    public string? Title { get; set; }
    
    [MaxLength(256)]
    public string? Description { get; set; }
    
    public required TaskItemStatus Status { get; set; } = TaskItemStatus.Created;
    
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    
    public override string ToString()
    {
        return $"[{Status}] {Title} (Created: {CreatedAt})";
    }
}