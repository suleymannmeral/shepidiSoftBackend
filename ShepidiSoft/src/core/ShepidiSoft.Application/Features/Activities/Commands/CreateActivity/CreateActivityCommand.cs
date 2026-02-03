
using MediatR;

namespace ShepidiSoft.Application.Features.Activities.Commands.CreateActivity;

public sealed record CreateActivityCommand(
    string Title,
    string Description,
    DateTime Date,
    bool IsOnline,
    string Location,
    string MeetingUrl
    )  // dışarıya ne açılacak
    : IRequest<ServiceResult<CreateActivityResponse>>;
























