﻿using TestTestCMS.Repositories.Abstractions;
using TestTestCMS.Repositories.EFCore;
using TestTestCMS.Repositories.EFCore.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection;

public static class PostgreSQLServiceExtensions
{
    public static IServiceCollection AddPostgresRepositories(this IServiceCollection services, string connectionStringName)
    {

        services.AddScoped<ISetupRepository, SetupRepository>();

        services.AddEFCoreRepositories();

        services.AddDbContext<TestTestCMSDbContext>((sp, options) =>
            options.UseNpgsql(sp.GetConnectionString(connectionStringName)));

        return services;
    }

    private static string GetConnectionString(this IServiceProvider provider, string connectionStringName)
    {
        var configuration = provider.GetRequiredService<IConfiguration>();
        var connString = configuration.GetConnectionString(connectionStringName);
        return connString ?? throw new InvalidOperationException($"Connection string '{connectionStringName}' not found.");
    }
}