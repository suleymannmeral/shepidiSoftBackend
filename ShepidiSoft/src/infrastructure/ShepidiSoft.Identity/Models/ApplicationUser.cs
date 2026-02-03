using Microsoft.AspNetCore.Identity;

namespace ShepidiSoft.Identity.Models;


public class ApplicationUser : IdentityUser<Guid>
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string? LinkednUrl { get; set; } 
    public string? GithubUrl { get; set; } 
    public string? YoutubeUrl { get; set; } 
    public DateTime DateOfBirth { get; set; }
    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}