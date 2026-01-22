using ShepidiSoft.Domain.Entities.Common;

namespace ShepidiSoft.Domain.Entities;

public sealed class Instructor : BaseEntity<int>, IAuditEntity
{
    public string UserId { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Bio { get; set; } = null!;
    public string Expertise { get; set; } = null!;
    public bool IsActive { get; set; } = true;

    // Navigation Properties  
    public ICollection<Course> Courses { get; set; } = new List<Course>();
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
}