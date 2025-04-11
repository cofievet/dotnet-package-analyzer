using DotnetPackageAnalyzer.Domain.Models;
using DotnetPackageAnalyzer.Domain.Ports;
using DotnetPackageAnalyzer.Infrastructure.Models;

namespace DotnetPackageAnalyzer.Infrastructure.Providers;

public class SaveApplication : ISaveApplication
{
    public async Task SaveApplicationAsync(Application application, CancellationToken cancellationToken)
    {
        await Task.Run(() => ApplicationData.Applications.Add(application), cancellationToken);
    }
}
