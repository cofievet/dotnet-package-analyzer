using DotnetPackageAnalyzer.Domain.Models;
using DotnetPackageAnalyzer.Domain.Ports;
using DotnetPackageAnalyzer.Infrastructure.Models;
using System.Text.Json;

namespace DotnetPackageAnalyzer.Infrastructure.Adapters;

public class DotnetApplicationAdapter : IProvidePackage
{
    private readonly JsonSerializerOptions jsonSerializerOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
    };

    public IReadOnlyCollection<Package> GetPackagesAsync(string applicationName)
    {
        using StreamReader r = new($"C:\\TFS\\GIT\\{applicationName}\\src\\Api\\obj\\project.assets.json");
        string json = r.ReadToEnd();
        ProjectAssets? application = JsonSerializer.Deserialize<ProjectAssets>(json, jsonSerializerOptions);

        return [];
    }
}
