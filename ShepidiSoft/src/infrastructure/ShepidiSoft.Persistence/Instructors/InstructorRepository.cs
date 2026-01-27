using ShepidiSoft.Application.Contracts.Persistence;
using ShepidiSoft.Domain.Entities;
using ShepidiSoft.Persistence.Context;

namespace ShepidiSoft.Persistence.Instructors;

public sealed class InstructorRepository(AppDbContext context) : GenericRepository<Instructor, int>(context), IInstructorRepository
{
}
