using System;
using System.Collections.Generic;
using System.Linq;
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
	}
}
