using DotnetPackageAnalyzer.Domain.Models;

namespace DotnetPackageAnalyzer.Domain.Ports;

public interface ISaveApplication
{
    Task SaveApplicationAsync(Application application, CancellationToken cancellationToken);
}
