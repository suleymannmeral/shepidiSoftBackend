using ShepidiSoft.Domain.Entities.Common;

namespace ShepidiSoft.Domain.Entities;

public sealed class Assignment : BaseEntity<int>
{
    public int MyProperty { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public DateTime? DueDate { get; set; } // Teslim tarihi (Opsiyonel olabilir)
    public bool IsActive { get; set; } = true; // Aktif/Pasif yönetimi için

    // Foreign Key: 1 Assignment -> 1 Course
    public int CourseId { get; set; }

    // Navigation Properties
    public Course Course { get; set; } = null!;

    // 1 Assignment -> N Submissions (Henüz AssignmentSubmission sınıfı yoksa burayı yorum satırı yapabilirsiniz)
     public ICollection<AssignmentSubmission> Submissions { get; set; } = new List<AssignmentSubmission>();
}