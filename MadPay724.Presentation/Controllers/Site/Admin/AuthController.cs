using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadPay724.Data.DatabaseContext;
using MadPay724.Data.Models;
using MadPay724.Repo.Infrastructure;
using MadPay724.Services.Site.Admin.Auth.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MadPay724.Presentation.Controllers.Site.Admin
{
	[Route("site/admin/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IUnitOfWork<MadpayDbContext> _db;
		private readonly IAuthService _authService;

		public AuthController(IUnitOfWork<MadpayDbContext> dbContext, IAuthService authService)
		{
			_db = dbContext;
			_authService = authService;
		}

		public async Task<IActionResult> Register(string username, string password)
		{
			username = username.ToLower();
			if (await _db.UserRepository.UserExists(username))
				return BadRequest("این نام کاربری وجود دارد");

			var userToCreate=new User
			{
				UserName = username,
				Address = "",
				City = "",
				DateOfBirth = "",
				Gender = "",
				IsActive = true,
				Name = "",
				PhoneNumber = "",
				Status = true
			};

			var createdUser = await _authService.Register(userToCreate, password);

			return StatusCode(201);

		}
	}
}
