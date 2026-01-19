using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShepidiSoft.Domain.Entities;



namespace ShepidiSoft.Persistence.Activities
{
    public sealed class ActivityConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
