using MediatR;
using ShepidiSoft.Application.Contracts.Persistence;
using ShepidiSoft.Domain.Entities;
using System.Diagnostics.Metrics;

namespace ShepidiSoft.Application.Features.Activities.Commands.CreateActivity;

public sealed class CreateActivityCommandHandler(
    IActivityRepository activityRepository,
    IUnitOfWork unitOfWork)
        : IRequestHandler<CreateActivityCommand, ServiceResult<CreateActivityResponse>>
{
    public Task<ServiceResult<CreateActivityResponse>> Handle(CreateActivityCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    private static Activity CreateMeasurement(
CreateActivityCommand request)
    {
        return new Activity
        {
          Title= request.Title,

        };
    }
}