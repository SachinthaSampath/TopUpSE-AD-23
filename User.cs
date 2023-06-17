using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TopUpAD_GUI
{
	class User
	{
		public static bool Authenticate(string username, string password)
		{
			if (username.Equals("admin") && password.Equals("123"))
			{
				return true;
			}
			return false;
		}

		 public static string GetPasswordHash(string input)
		{
			using (SHA1Managed sha1 = new SHA1Managed())
			{
				byte[] inputBytes = Encoding.UTF8.GetBytes(input);
				byte[] hashBytes = sha1.ComputeHash(inputBytes);

				StringBuilder sb = new StringBuilder();
				foreach (byte b in hashBytes)
				{
					sb.Append(b.ToString("x2"));
				}
				return sb.ToString();
			}
		}
	}
}
