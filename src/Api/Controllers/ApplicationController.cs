using DotnetPackageAnalyzer.Domain.Commands;
using DotnetPackageAnalyzer.Domain.Features;
using DotnetPackageAnalyzer.Domain.Ports;
using Microsoft.AspNetCore.Mvc;

namespace DotnetPackageAnalyzer.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ApplicationController(CreateApplicationWithPackage createApplicationWithPackage, IProvideApplication provideApplication) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateApplicationCommand command, CancellationToken cancellationToken = default)
    {
        await createApplicationWithPackage.Execute(command, cancellationToken);
        return Created();
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] string name, CancellationToken cancellationToken = default)
    {
        return Ok(await provideApplication.GetApplicationAsync(name, cancellationToken));
    }
}
