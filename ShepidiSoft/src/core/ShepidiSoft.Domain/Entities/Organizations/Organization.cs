using ShepidiSoft.Domain.Entities.Common;

namespace ShepidiSoft.Domain.Entities.Organizations;

public sealed class Organization:BaseEntity<int>
{
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? LogoUrl { get; set; }
}
