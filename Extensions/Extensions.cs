using CodeToSql.IServices;
using CodeToSql.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CodeToSql.Extensions;
public static class AddService
{
    public static IServiceCollection ServiceResolve(this IServiceCollection services)
    {
        services.AddTransient<ISqlGenerator, SqlGenerator>();

        return services;
    }
}

public static class Consumer
{
    public static IServiceCollection ConsumerResolve(this IServiceCollection services)
    {
        return services;
    }
}
