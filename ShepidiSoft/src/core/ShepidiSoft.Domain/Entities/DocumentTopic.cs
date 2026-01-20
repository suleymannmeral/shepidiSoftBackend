
using ShepidiSoft.Domain.Entities.Common;

namespace ShepidiSoft.Domain.Entities;

public sealed class DocumentTopic : BaseEntity<int>
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }

    // Navigation Properties
    public ICollection<Document> Documents { get; set; } = new List<Document>();
}