using AutoMapper;
using ShepidiSoft.Application.Features.Activities.Commands.CreateActivity;
using ShepidiSoft.Domain.Entities;

namespace ShepidiSoft.Application.Features.Activities;

public sealed class ActivityMappingProfile : Profile
{
    public ActivityMappingProfile()
    {
        CreateMap<CreateActivityCommand, Activity>();
    }
}
