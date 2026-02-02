using MediatR;
using ShepidiSoft.Application.Contracts.Persistence;

namespace ShepidiSoft.Application.Features.Activities.Commands.CreateActivity;

public sealed class CreateActivityCommandHandler(
    IActivityRepository activityRepository,
    IUnitOfWork unitOfWork) 
        : IRequestHandler<CreateActivityCommand, CreateActivityResponse>
{
    public Task<CreateActivityResponse> Handle(CreateActivityCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

