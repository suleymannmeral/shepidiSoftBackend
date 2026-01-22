using ShepidiSoft.Domain.Entities.Common;

namespace ShepidiSoft.Domain.Entities.Organizations;

public sealed class OrganizationMember:BaseEntity<int>,IAuditEntity
{    public Guid UserId { get; set; }
    public ICollection<OrganizationMemberPosition> Positions { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
}
