using Microsoft.AspNetCore.Mvc;
using TestSchedulingMessageWithTwilioandHangfire.Services;

namespace TestSchedulingMessageWithTwilioandHangfire.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IHangfireService _hangfireService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IHangfireService hangfireService)
        {
            _logger = logger;
            _hangfireService=hangfireService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            _hangfireService.ScheduleMessage("+201018451083","Hello Ahmed" , new DateTime(2023,12,17,10,10,0));

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
