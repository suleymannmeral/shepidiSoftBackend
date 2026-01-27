using ShepidiSoft.Application.Contracts.Persistence;
using ShepidiSoft.Domain.Entities;
using ShepidiSoft.Persistence.Context;

namespace ShepidiSoft.Persistence.Students;

public sealed class StudentRepository(AppDbContext context) : GenericRepository<Student, Guid>(context), IStudentRepository
{
}
