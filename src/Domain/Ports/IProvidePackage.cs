using DotnetPackageAnalyzer.Domain.Models;

namespace DotnetPackageAnalyzer.Domain.Ports;

public interface IProvidePackage
{
    IReadOnlyCollection<Package> GetPackagesAsync(string applicationName);
}