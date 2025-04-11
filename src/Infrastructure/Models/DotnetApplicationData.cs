namespace DotnetPackageAnalyzer.Infrastructure.Models;

public class ProjectAssets
{
    public int Version { get; set; }
    public Dictionary<string, Target> Targets { get; set; }
}

public class Target
{
    public Dictionary<string, TargetLibrary> Libraries { get; set; }
}

public class TargetLibrary
{
    public string Type { get; set; }
}