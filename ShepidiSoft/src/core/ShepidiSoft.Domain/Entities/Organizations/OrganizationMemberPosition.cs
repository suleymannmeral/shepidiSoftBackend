namespace ShepidiSoft.Domain.Entities.Organizations;

public sealed class OrganizationMemberPosition
{
    public int OrganizationMemberId { get; set; }
    public OrganizationMember OrganizationMember { get; set; }
    public int OrganizationPositionId { get; set; }
    public OrganizationPosition OrganizationPosition { get; set; }
}
