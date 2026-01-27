using ShepidiSoft.Application.Contracts.Persistence;
using ShepidiSoft.Domain.Entities;
using ShepidiSoft.Persistence.Context;

namespace ShepidiSoft.Persistence.Assignments;

public class AssignmentRepository(AppDbContext context) : GenericRepository<Assignment, int>(context), IAssignmentRepository
{
}
