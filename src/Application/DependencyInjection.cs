using Application.Mapping.StudentMapping;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
    {
        services.AddMediatR(cfg => { cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);});
        services.AddAutoMapper(typeof(AutoMapperProfile));
        return services;
    }
}
