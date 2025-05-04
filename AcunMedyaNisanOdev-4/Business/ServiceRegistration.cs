using AutoMapper;
using Business.Implementations;
using Business.Services.Interfaces;
using Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace Business;

public static class ServiceRegistration
{
    public static void AddBusinessServices(this IServiceCollection services)
    {
        services.AddScoped<IApplicationService, ApplicationManager>();
        services.AddAutoMapper(typeof(MappingProfiles));

        services.AddScoped<IBlacklistService, BlacklistManager>();

        services.AddScoped<IBootcampService, BootcampManager>();
    }
}
