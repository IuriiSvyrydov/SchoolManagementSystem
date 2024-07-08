using Microsoft.Extensions.DependencyInjection;
using Services.Abstracts;
using Services.Implementations;

namespace Services;

public static class DependencyInjection
{
    public static IServiceCollection AddServiceLayer(this IServiceCollection services)
    {
        services.AddScoped<IDepartmentService, DepartmentService>();
        services.AddScoped<IStudentService, StudentService>();
        return services;
    }
    
}