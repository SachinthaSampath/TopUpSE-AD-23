using System;
using System.Windows.Forms;
using TopUpAD_GUI.Models;

namespace TopUpAD_GUI
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
			//when the initial Login object is created by the runtime, 
			//it will be set to the login reference in the InterfaceManager class
			InterfaceManager.SetLogin(this);
		}

		
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void PictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void Button1_Click(object sender, EventArgs e)
		{

			//this is the event handler for login button click
			//take the username
			string uname = tb_uname.Text.Trim();			
			if (uname.Equals(""))
			{
				//focus the username text box
				tb_uname.Focus();
				return; //terminate the execution
			}

			string psw = tb_psw.Text.Trim();
			if (psw.Equals(""))
			{
				tb_psw.Focus();
				return;
			}

			//add authentication code
			if (User.Authenticate(uname, psw))
			{
				MessageBox.Show("Login success!!");
				InterfaceManager.ShowDashboard();
			}
			else
			{
				MessageBox.Show("Invalid credentials!!");
				tb_uname.SelectAll();
				tb_uname.Focus();
				tb_psw.Clear();
			}
		}

		private void Tb_uname_Enter(object sender, EventArgs e)
		{
			Console.WriteLine("Focused!");
		}

		private void Tb_uname_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			MessageBox.Show("Mouse double clicked", "!!!",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public void clear()
		{
			tb_psw.Clear();
			tb_uname.Clear();
			tb_uname.Focus();
		}
	}
}
