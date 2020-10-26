using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadPay724.Data.DatabaseContext;
using MadPay724.Data.Infrastructure;
using MadPay724.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MadPay724.Presentation.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private readonly IUnitOfWork<MadpayDbContext> _db;

		public WeatherForecastController(IUnitOfWork<MadpayDbContext> dbContext)
		{
			_db = dbContext;
		}

		//private static readonly string[] Summaries = new[]
		//{
		//	"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		//};

		//private readonly ILogger<WeatherForecastController> _logger;

		//public WeatherForecastController(ILogger<WeatherForecastController> logger)
		//{
		//	_logger = logger;
		//}

		//[HttpGet]
		//public IEnumerable<WeatherForecast> Get()
		//{
		//	var rng = new Random();
		//	return Enumerable.Range(1, 5).Select(index => new WeatherForecast
		//	{
		//		Date = DateTime.Now.AddDays(index),
		//		TemperatureC = rng.Next(-20, 55),
		//		Summary = Summaries[rng.Next(Summaries.Length)]
		//	})
		//	.ToArray();
		//}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<string>>> Get()
		{
			//var user=new User()
			//{
			//	Address="",
			//	City="",
			//	DateOfBirth="",
			//	Gender="",
			//	IsActive=true,
			//	Name="",
			//	PasswordHash=new byte[]{0x20, 0x20 , 0x20 , 0x20 , 0x20 , 0x20 , 0x20 },
			//	PasswordSalt=new byte[]{0x20, 0x20 , 0x20 , 0x20 , 0x20 , 0x20 , 0x20 },
			//	PhoneNumber="",
			//	Status=true,
			//	UserName=""
			//};
			//await _db.UserRepository.InsertAsync(user);
			//await _db.SaveAsync();

			//var users = await _db.UserRepository.GetAllAsync();

			//return Ok(users);
			return Ok("Amir Azizi");
		}
	}
}
