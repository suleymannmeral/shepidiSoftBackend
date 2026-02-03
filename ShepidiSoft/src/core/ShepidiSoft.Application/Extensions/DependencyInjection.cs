using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ShepidiSoft.Application.Features.Activities.Commands.CreateActivity;
using System.Reflection;

namespace ShepidiSoft.Application.Extensions;

public static class DependencyInjection
{

    public static IServiceCollection AddApplicationExt(this IServiceCollection services)
    {
        MediatrExt(services);
        return services;
    }

    public static IServiceCollection MediatrExt(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly())
        );
        services.AddFluentValidationAutoValidation();

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        return services;
    }
}
