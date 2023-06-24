using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TopUpAD_GUI.Database;
using TopUpAD_GUI.Helpers;

namespace TopUpAD_GUI.Models
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

			//status variable
			bool isSuccess = false;

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
					string pswHashFromUser = Security.GetPasswordHash(password);
					//compare values
					if (pswHashFromDb.Equals(pswHashFromUser))
					{
						isSuccess = true;
					}
				}
			}
			con.Close();
			sdr.Close();
			return isSuccess;
		}		 
	}
}
