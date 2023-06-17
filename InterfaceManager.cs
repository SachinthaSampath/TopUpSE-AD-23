using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopUpAD_GUI
{
	class InterfaceManager
	{
		private static Login login = null;
		private static Dashboard dashboard = null;
		private static UserManagement umanage = null;
		private static CustomerManagement cmanage = null;

		public static void SetLogin(Login l)
		{
			login = l;
		}

		public static void ShowLogin()
		{
			//check whether login reference is null, if so initialize it
			//in the initial run, login reference will be null
			//later, if the Login object is is disposed state, it cannot be re-used
			if (login == null || login.IsDisposed)
			{
				login = new Login();
			}

			//hide all other interfaces before showing login interface
			HideAll();
			//show the login interface
			login.Show();
		}

		public static void ShowDashboard()
		{
			if (dashboard == null || dashboard.IsDisposed)
			{
				dashboard = new Dashboard();				
			}
			HideAll();
			dashboard.Show();
		}

		public static void ShowUserManage()
		{
			if (umanage == null || umanage.IsDisposed)
			{
				umanage = new UserManagement();
			}
			HideAll();
			umanage.Show();
		}


		//hide all the interfaces. Check whether each reference is null before calling hide() on them
		private static void HideAll()
		{
			if (login != null) login.Hide();
			if (dashboard != null) dashboard.Hide();
			if (umanage != null) umanage.Hide();
		}

	}
}
