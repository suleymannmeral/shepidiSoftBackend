using ShepidiSoft.Domain.Entities.Common;

namespace ShepidiSoft.Domain.Entities.Organizations;

public sealed class OrganizationPosition:BaseEntity<int>
{
    public string Name { get; set; } = null!;
    public bool IsActive { get; set; } = true;
    public ICollection<OrganizationMemberPosition> Members { get; set; }


}
