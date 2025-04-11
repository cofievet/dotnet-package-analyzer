using DotnetPackageAnalyzer.Domain.Models;
using DotnetPackageAnalyzer.Domain.Ports;
using DotnetPackageAnalyzer.Infrastructure.Models;

namespace DotnetPackageAnalyzer.Infrastructure.Adapters;

public class ApplicationAdapter : IProvideApplication
{
    public async Task<Application?> GetApplicationAsync(string name, CancellationToken cancellationToken)
    {
        return await Task.Run(() => ApplicationData.Applications.SingleOrDefault(a => a.Name == name));
    }
}
