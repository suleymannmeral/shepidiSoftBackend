using ShepidiSoft.Application.Contracts.Persistence;
using ShepidiSoft.Domain.Entities;
using ShepidiSoft.Persistence.Context;

namespace ShepidiSoft.Persistence.Courses;

public sealed class CourseRepository(AppDbContext context) : GenericRepository<Course, int>(context), ICourseRepository
{
}
