using Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
	class EmployeeBusiness : IEmployeeBusiness
	{
		public string GetEmployeeName(int EmpId)
		{
			return "Abcdef" + EmpId;
		}
	}
}
