using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShepidiSoft.Domain.Entities.Organizations;

namespace ShepidiSoft.Persistence.OrganizationPositions;

public sealed class OrganizationPositionConfiguration : IEntityTypeConfiguration<OrganizationPosition>
{
    public void Configure(EntityTypeBuilder<OrganizationPosition> builder)
    {
        throw new NotImplementedException();
    }
}
