using Microsoft.AspNetCore.Mvc;
namespace Api.net.Controllers;

[ApiController]
[Route("api/[controller]")] //Ruta general de todos los endpoints
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    private static List<WeatherForecast> ListWeatherForecast = new List<WeatherForecast>();

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;

        if (ListWeatherForecast == null || !ListWeatherForecast.Any())
        {
            ListWeatherForecast = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
       .ToList();

        }
    }

    [HttpGet(Name = "GetWeatherForecast")]
    [Route("Get/weatherforecast")]
    [Route("[action]")] // este valor sirve para llamar el Get desde la ruta EJEMPLO: http://localhost:5240/api/weatherforecast/get
    public IEnumerable<WeatherForecast> Get()
    {
        return ListWeatherForecast;
    }
    [HttpPost]
    public IActionResult Post(WeatherForecast weatherForecast)
    {
        ListWeatherForecast.Add(weatherForecast);

        return Ok("Introduce New User");

    }
    [HttpDelete("{index}")]
    public IActionResult Delete(int index)
    {
        if (ListWeatherForecast.Count < index)
        {
            return BadRequest("The given ID is out of bounds.");
        }

        ListWeatherForecast.RemoveAt(index);

        return Ok("Forecast was successfully removed.");
    }
}