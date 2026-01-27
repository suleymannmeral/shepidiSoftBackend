using ShepidiSoft.Application.Contracts.Persistence;
using ShepidiSoft.Domain.Entities.Organizations;
using ShepidiSoft.Persistence.Context;


namespace ShepidiSoft.Persistence.OrganizationMembers;

public sealed class OrganizationMemberRepository(AppDbContext context) : GenericRepository<OrganizationMember, Guid>(context), IOrganizationMemberRepository
{
}
