namespace DotnetPackageAnalyzer.Domain.Models;

public class Application
{
    public required string Name { get; set; }

    public required IReadOnlyCollection<Package> Packages { get; set; }
}
