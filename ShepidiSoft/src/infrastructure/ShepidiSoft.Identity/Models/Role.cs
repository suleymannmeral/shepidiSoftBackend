using Microsoft.AspNetCore.Identity;

namespace ShepidiSoft.Identity.Models;

public class Role : IdentityRole<Guid>
{
    public string? Description { get; set; }
    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
