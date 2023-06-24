using System;
using System.Security.Cryptography;
using System.Text;

namespace TopUpAD_GUI.Helpers
{
	class Security
	{
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
