using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShepidiSoft.Domain.Entities;

namespace ShepidiSoft.Persistence.DocumentTopics;

public sealed class DocumentTopicConfiguration : IEntityTypeConfiguration<DocumentTopic>
{
    public void Configure(EntityTypeBuilder<DocumentTopic> builder)
    {
        throw new NotImplementedException();
    }
}
