
using ShepidiSoft.Domain.Entities.Common;

namespace ShepidiSoft.Domain.Entities;

public sealed class Offering:BaseEntity<int>,IAuditEntity
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public bool IsActive { get; private set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
}
