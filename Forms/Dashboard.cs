using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopUpAD_GUI
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();
		}

		private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
		{
			InterfaceManager.ShowLogin();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			InterfaceManager.ShowLogin();
		}

		private void Btn_users_Click(object sender, EventArgs e)
		{
			InterfaceManager.ShowUserManage();
		}
	}
}
