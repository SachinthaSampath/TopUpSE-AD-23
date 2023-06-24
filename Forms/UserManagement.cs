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
				tb_id.Text = sdr.GetString(0);
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
	}
}
