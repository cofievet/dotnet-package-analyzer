using DotnetPackageAnalyzer.Domain.Commands;
using DotnetPackageAnalyzer.Domain.Models;
using DotnetPackageAnalyzer.Domain.Ports;

namespace DotnetPackageAnalyzer.Domain.Features;

public class CreateApplicationWithPackage(ISaveApplication saveApplication, IProvidePackage providePackage)
{
    public async Task Execute(CreateApplicationCommand command, CancellationToken cancellationToken)
    {
        IReadOnlyCollection<Package> packages = providePackage.GetPackagesAsync(command.Name); 

        Application application = new()
        {
            Name = command.Name,
            Packages = packages,
        };

        // Save the application
        await saveApplication.SaveApplicationAsync(application, cancellationToken);
    }
}
