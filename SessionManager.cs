using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKZN_Howard_Clinic_Management_System
{
	class SessionManager
	{
		//MEMBERS
		bool manager;
		bool admin;
		bool doctor;
		bool nurse;

		public SessionManager()
		{
			this.manager = false;
			this.admin = false;
			this.doctor = false;
			this.nurse = false;
		}

		public int getCurrentSesion()
		{
			bool [] session = new bool[4];
			session[0] = manager;
			session[1] = admin;
			session[2] = doctor;
			session[3] = nurse;

			for(int i = 0; i < session.Length; i++)
			{
				if(session[i] == true)
				{
					return 1;
				}
			}
			return 0;
		}
	}
}
