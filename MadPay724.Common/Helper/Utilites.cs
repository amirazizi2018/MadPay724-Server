using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace MadPay724.Common.Helper
{
	public class Utilites
	{
		public static void CreatePasswordHash(string password,out byte[] passwordHash,out byte[] passwordSalt)
		{
			using (var hamc = new System.Security.Cryptography.HMACSHA512())
			{
				passwordSalt = hamc.Key;
				passwordHash = hamc.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
			}
			
		}
	}
}
