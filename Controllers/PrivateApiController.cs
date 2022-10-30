using Microsoft.AspNetCore.Mvc;

namespace ecommerceproject.Controllers;

[ApiController]
[Route("[controller]")]
public class PrivateApiController : ControllerBase
{
	private static readonly string[] Summaries = new[]
	{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
	};

	private readonly ILogger<PrivateApiController> _logger;

	public PrivateApiController(ILogger<PrivateApiController> logger)
	{
		_logger = logger;
	}

}
