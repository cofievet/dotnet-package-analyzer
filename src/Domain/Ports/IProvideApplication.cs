using DotnetPackageAnalyzer.Domain.Models;

namespace DotnetPackageAnalyzer.Domain.Ports;

public interface IProvideApplication
{
    Task<Application?> GetApplicationAsync(string name, CancellationToken cancellationToken);
}
