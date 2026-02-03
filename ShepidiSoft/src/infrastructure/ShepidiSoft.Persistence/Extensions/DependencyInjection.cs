using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShepidiSoft.Application.Contracts.Persistence;
using ShepidiSoft.Persistence.Activities;
using ShepidiSoft.Persistence.Context;
using ShepidiSoft.Persistence.Interceptors;
using ShepidiSoft.Persistence.Options;

namespace ShepidiSoft.Persistence.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceExt(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            var connectionStrings = configuration
                .GetSection(ConnectionStringOption.Key)
                .Get<ConnectionStringOption>();


            options.UseSqlServer(connectionStrings!.SqlServer, sqlOptions =>
            {
                sqlOptions.MigrationsAssembly(typeof(PersistenceAssembly).Assembly.FullName);
            });
            options.AddInterceptors(new AuditDbContextInterceptor());
        });

        services.AddScoped<IActivityRepository, ActivityRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }


}
