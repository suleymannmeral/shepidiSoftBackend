using MediatR;
using ShepidiSoft.Application.Contracts.Persistence;
using ShepidiSoft.Domain.Entities;

namespace ShepidiSoft.Application.Features.Activities.Commands.CreateActivity;

public sealed class CreateActivityCommandHandler(
    IActivityRepository activityRepository,
    IUnitOfWork unitOfWork)
        : IRequestHandler<CreateActivityCommand, ServiceResult<CreateActivityCommandResponse>>
{
    public async Task<ServiceResult<CreateActivityCommandResponse>> Handle(CreateActivityCommand request, CancellationToken cancellationToken)
    {
        var activity = CreateActivity(request);
        await PersistAsync(activity);

        return ServiceResult<CreateActivityCommandResponse>
           .Success(new CreateActivityCommandResponse(activity.Id));
    }

    private static Activity CreateActivity(
CreateActivityCommand request)
    {
        return new Activity
        {
          Title= request.Title,
          Description= request.Description,
          Date=request.Date,
          IsOnline= request.IsOnline,
          Location= request.Location,
          OnlineMeetingUrl=request.MeetingUrl,


        };
    }

    //Db'ye yansıt
    private async Task PersistAsync(Activity activity)
    {
        await activityRepository.AddAsync(activity);
        await unitOfWork.SaveChangesAsync();
    }
}

   