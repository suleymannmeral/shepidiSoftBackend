using ShepidiSoft.Domain.Entities.Common;

namespace ShepidiSoft.Domain.Entities.Organizations;

public sealed class OrganizationMember:BaseEntity<int>
{    public Guid UserId { get; set; }
    public ICollection<OrganizationMemberPosition> Positions { get; set; }
}
