using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TopUpAD_GUI.Database;
using TopUpAD_GUI.Helpers;

namespace TopUpAD_GUI
{
	public partial class UserManagement : Form
	{
		public UserManagement()
		{
			InitializeComponent();
		}

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Btn_home_Click(object sender, EventArgs e)
		{
			InterfaceManager.ShowDashboard();
		}

		private void Btn_load_Click(object sender, EventArgs e)
		{
			SqlConnection con =  DB.GetConnection();
			con.Open();

			string sql = "SELECT id,name,uname,contact FROM userlogin";

			SqlCommand cmd = new SqlCommand(sql, con);

			SqlDataAdapter sda = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			sda.Fill(dt);

			dataGridView1.DataSource = dt;
			con.Close();
		}

		private void Btn_save_Click(object sender, EventArgs e)
		{
			//set data from text fields
			string name = tb_name.Text.Trim();
			string uname = tb_uname.Text.Trim();
			string psw = tb_psw.Text.Trim();
			string contact = tb_contact.Text.Trim();

			//** add validateions here

			//generate the sha1 hash for the password
			string hashed_password = Security.GetPasswordHash(psw);

			string sql = "INSERT INTO userlogin(name,uname,password_hash,contact) VALUES ('"+name+
				"','"+uname+"','"+hashed_password + "','"+contact+"')";
			SqlConnection con = DB.GetConnection();
			con.Open();
			SqlCommand cmd = new SqlCommand(sql, con);
			 int numOfAffectedRows = cmd.ExecuteNonQuery();
			if (numOfAffectedRows > 0)
			{
				MessageBox.Show("Successfully Saved!");
				clear();
			}
			else
			{
				MessageBox.Show("Unable to save the user!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			con.Close();
		}

		public void clear()
		{
			tb_contact.Clear();
			tb_id.Clear();
			tb_name.Clear();
			tb_psw.Clear();
			tb_uname.Clear();
			tb_id.Focus();
		}

		private void Btn_search_Click(object sender, EventArgs e)
		{
			//take the userId as string 
			string userIdStr = tb_id.Text.Trim();
			//this variable will hold converted int id if conversion proccess is successfull
			int userIdInt;
			//try to convert in to integer
			if (! int.TryParse(userIdStr,out userIdInt))
			{   //if the conversion is not successfull
				tb_id.Focus();
				tb_id.SelectAll();
				return;
			}

			//build the sql
			string sql = "SElECT id,name,uname,contact FROM userlogin WHERE id = "+userIdInt+"";

			SqlConnection con = DB.GetConnection();
			con.Open();
			SqlCommand cmd = new SqlCommand(sql, con);
			SqlDataReader sdr =  cmd.ExecuteReader();

			if (sdr.Read())
			{
				//if Read() is successfull; result has rows
				//we found the user, user data in the sdr
				//tb_id.Text = sdr.GetInt32(0).ToString() ;
				tb_name.Text = sdr.GetString(1);
				tb_uname.Text = sdr.GetString(2);
				tb_contact.Text = sdr.GetString(3);
			}
			else
			{
				//if Read() is un successfull; it doesn't have any rows
				MessageBox.Show("No user found for the ID!", "Not found!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				tb_id.Focus();
				tb_id.SelectAll();
			}

			sdr.Close();
			con.Close();
		}

		private void Btn_update_Click(object sender, EventArgs e)
		{
			//take data from text fields
			string id = tb_id.Text.Trim();
			string name = tb_name.Text.Trim();
			string uname = tb_uname.Text.Trim();
			string psw = tb_psw.Text.Trim();
			string contact = tb_contact.Text.Trim();

			//check whether ID is empty, means user has not search and selected
			if (id.Equals(""))
			{
				MessageBox.Show("Please search a valid item first!");
				tb_id.Focus();
				return;
			}
			
			//get the connection
			SqlConnection con = DB.GetConnection();
			//open the connection
			con.Open();

			//start the transaction
			string sql = "begin transaction";
			SqlCommand cmd1 = new SqlCommand(sql, con);
			cmd1.ExecuteNonQuery();

			if (psw.Equals(""))
			{
				//use don't want to update the password
				sql = "UPDATE userlogin SET name ='" + name + "', uname = '" + uname + "',  contact='" + contact + "' WHERE id=" + id + "";
			}
			else
			{
				//user want to update the password
				sql = "UPDATE userlogin SET name ='"+name+"', uname = '"+uname+"', password_hash='"+Security.GetPasswordHash(psw)+ "', contact='" + contact + "' WHERE id=" + id + "";
			}

			//run the sql to update
			SqlCommand cmd2 = new SqlCommand(sql, con);
			cmd2.ExecuteNonQuery();

			

			DialogResult x = MessageBox.Show("Do you wnat to update the password?", "Confirm!", MessageBoxButtons.YesNo);
			if (x == DialogResult.Yes)
			{
				//proceed with password update
				//since update is successfull, commit the transaction
				sql = "COMMIT TRANSACTION";
				SqlCommand cmd3 = new SqlCommand(sql, con);
				cmd3.ExecuteNonQuery();

			}
			else if (x == DialogResult.No)
			{
				//proceed without password update
				//since update is successfull, commit the transaction
				sql = "ROLLBACK TRANSACTION";
				SqlCommand cmd3 = new SqlCommand(sql, con);
				cmd3.ExecuteNonQuery();
			}

			con.Close();
		}

		private void Btn_delete_Click(object sender, EventArgs e)
		{
			//get the id from text field
			string id = tb_id.Text.Trim();
			//validate id
			if (id.Equals(""))
			{
				tb_id.Focus();
				return;
			}

			DialogResult x = MessageBox.Show("Do you wnat to delte the user?", 
				"Confirm!", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if (x == DialogResult.Yes)
			{
				//proceed with password update
				SqlConnection con = DB.GetConnection();
				con.Open();
				string sql = "DELETE FROM userlogin WHERE id = '" + id + "'";
				SqlCommand cmd = new SqlCommand(sql, con);
				//execute and check the updated number of rows
				if (cmd.ExecuteNonQuery() == 1)
				{
					MessageBox.Show("Successfully deleted!");
				}
				else
				{
					MessageBox.Show("Error while deleting the user");
				}
			}
			else if (x == DialogResult.No)
			{
				//proceed without password update
				MessageBox.Show("abort!");
			}

			//try to implement transactions and rollback if the effected row count is more than 1
		}
	}
}
