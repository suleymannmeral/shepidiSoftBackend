using System.ComponentModel.DataAnnotations;

namespace ShepidiSoft.Identity.Models;

public class UserRole
{
    [Key]
    public int Id { get; set; }
    public Guid UserId { get; set; }
    public ApplicationUser User { get; set; } = null!;

    public Guid RoleId { get; set; }
    public Role Role { get; set; } = null!;
}
