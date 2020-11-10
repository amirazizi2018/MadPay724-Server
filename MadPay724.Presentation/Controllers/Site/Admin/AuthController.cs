using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadPay724.Data.DatabaseContext;
using MadPay724.Data.Dtos.Site.Admin;
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

		[HttpPost("register")]
		public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
		{
			userForRegisterDto.UserName = userForRegisterDto.UserName.ToLower();
			if (await _db.UserRepository.UserExists(userForRegisterDto.UserName))
				return BadRequest("این نام کاربری وجود دارد");

			var userToCreate = new User
			{
				UserName = userForRegisterDto.UserName,
				Address = "",
				City = "",
				DateOfBirth = DateTime.Now,
				Gender = true,
				IsActive = true,
				Name = userForRegisterDto.Name,
				PhoneNumber = userForRegisterDto.PhoneNumber,
				Status = true
			};

			var createdUser = await _authService.Register(userToCreate, userForRegisterDto.Password);

			return StatusCode(201);

		}
	}
}
