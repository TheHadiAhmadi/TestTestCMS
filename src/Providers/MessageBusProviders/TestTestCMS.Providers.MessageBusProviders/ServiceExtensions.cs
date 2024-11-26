using TestTestCMS.Providers.MessageBusProviders;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceExtensions
{
    public static IServiceCollection AddInMemoryMessageBusProvider(this IServiceCollection services)
    {
        // find all assemblies that start with "TestTestCMS"
        var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(x => !string.IsNullOrEmpty(x.FullName) && x.FullName.StartsWith("TestTestCMS"));

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(assemblies.ToArray()));
        services.AddScoped<IMessagePublisher, InMemoryMessagePublisher>();

        return services;
    }
}
