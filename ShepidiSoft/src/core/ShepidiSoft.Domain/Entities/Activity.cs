
using ShepidiSoft.Domain.Entities.Common;

namespace ShepidiSoft.Domain.Entities;

public sealed class Activity : BaseEntity<int>, IAuditEntity
{
    public string Title { get; private set; } = null!;
    public string Description { get; private set; } = null!;
    public DateTime Date { get; private set; }
    public bool IsOnline { get; private set; }
    public string? Location { get; private set; }  // google meet - zoom vs ..
    public string? OnlineMeetingUrl { get; private set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
}
