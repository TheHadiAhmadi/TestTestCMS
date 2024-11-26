using TestTestCMS.Providers.TemplateRenderingProviders;
using TestTestCMS.Providers.TemplateRenderingProviders.Abstractions;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceExtensions
{
    public static IServiceCollection AddScribanTemplateRenderingProvider(this IServiceCollection services)
    {
        services.AddScoped<ITemplateRenderingProvider, ScribanTemplateRenderingProvider>();
        return services;
    }
}
