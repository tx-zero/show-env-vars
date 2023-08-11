using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace show_env_vars.Controllers;

[ApiController]
public class EnvironmentVariablesController : ControllerBase
{
    [HttpGet("")]
    public Dictionary<string, string> Get()
    {
        var environmentVariables = new Dictionary<string, string>();
        foreach (DictionaryEntry variable in Environment.GetEnvironmentVariables())
        {
            environmentVariables[variable.Key?.ToString() ?? string.Empty] = variable.Value?.ToString() ?? string.Empty;
        }
        return environmentVariables;
    }
}
