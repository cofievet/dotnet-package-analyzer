using DotnetPackageAnalyzer.Domain.Features;
using DotnetPackageAnalyzer.Domain.Ports;
using DotnetPackageAnalyzer.Infrastructure.Adapters;
using DotnetPackageAnalyzer.Infrastructure.Providers;

namespace DotnetPackageAnalyzer.Api.Extensions;

internal static class ServiceExtensions
{
    internal static IServiceCollection AddApiServices(this IServiceCollection services)
    {
        services
            .AddTransient<IProvideApplication, ApplicationAdapter>()
            .AddTransient<IProvidePackage, DotnetApplicationAdapter>()
            .AddTransient<ISaveApplication, SaveApplication>()
            .AddTransient<CreateApplicationWithPackage>()
            ;
        return services;
    }
}
