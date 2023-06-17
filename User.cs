using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
			string sql = "SELECT password_hash FROM userlogin WHERE uname = '"+username+"'";
			
			//get the connection from DB class
			SqlConnection con =  DB.GetConnection();
			//open the connection
			con.Open();
			//create the SqlCommnd obejct
			SqlCommand cmd = new SqlCommand(sql, con);
			//once it is executed, will return a sql data reader with results included
			SqlDataReader sdr = cmd.ExecuteReader();
			//check whether it has rows
			if (sdr.HasRows)
			{
				//we have a valid entry with a username
				if (sdr.Read())
				{
					//advance to the first entry
					//get the first column value
					string pswHashFromDb = sdr.GetString(0);

					//generate hash from the given password to compare with the password hash from the database
					string pswHashFromUser = User.GetPasswordHash(password);
					//compare values
					if (pswHashFromDb.Equals(pswHashFromUser))
					{
						return true;
					}
				}
				return true;
			}
			else
			{
				//no rows means no entry with the given username
				return false;
			}
			 
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
