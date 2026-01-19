using ShepidiSoft.Domain.Entities.Common;

namespace ShepidiSoft.Domain.Entities;

public sealed class Student : BaseEntity<int>
{
    public string UserId { get; set; } = null!;
    public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;

    // Navigation Properties
    public ICollection<Course> Courses { get; set; } = new List<Course>();
    //public ICollection<AssignmentSubmission> AssignmentSubmissions { get; set; } = new List<AssignmentSubmission>();
}