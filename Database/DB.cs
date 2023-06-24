using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopUpAD_GUI.Database
{
	class DB
	{
		private static string ConString = @"Data Source=DESKTOP-64CFU0S\SQLEXPRESS; Initial Catalog=TOPUPSE23; Integrated Security=true;";
		private static SqlConnection con = null;
		public static SqlConnection GetConnection()
		{
			if (con == null)
			{
				con = new SqlConnection(ConString);
			}

			//open the connection
			/*if (con.State != System.Data.ConnectionState.Open)
			{
				con.Open();
			}*/
			return con;
		}
	}
}
