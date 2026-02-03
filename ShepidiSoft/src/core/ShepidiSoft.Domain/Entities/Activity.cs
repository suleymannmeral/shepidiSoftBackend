
using ShepidiSoft.Domain.Entities.Common;

namespace ShepidiSoft.Domain.Entities;

public sealed class Activity : BaseEntity<int>, IAuditEntity
{
    public string Title { get; init; } = null!;
    public string Description { get; init; } = null!;
    public DateTime Date { get; init; }
    public bool IsOnline { get; init; }
    public string? Location { get; init; }  // google meet - zoom vs ..
    public string? OnlineMeetingUrl { get; init; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
}
