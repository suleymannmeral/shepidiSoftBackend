using ShepidiSoft.Domain.Entities.Common;

namespace ShepidiSoft.Domain.Entities;

public sealed class Announcement : BaseEntity<int>
{
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;
    public DateTime PublishedAt { get; set; }
    public string CreatedByUserId { get; set; } = null!;
}