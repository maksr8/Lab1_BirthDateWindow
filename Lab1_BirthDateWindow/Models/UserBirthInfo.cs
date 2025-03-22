using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_BirthDateWindow.Models
{
    internal class UserBirthInfo
    {
		private DateTime _birthDate;

		public DateTime BirthDate
		{
			get { return _birthDate; }
			set { _birthDate = value; }
		}


	}
}
