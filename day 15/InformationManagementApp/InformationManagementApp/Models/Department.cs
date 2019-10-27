using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformationManagementApp.Models
{
	public class Department
	{
		public Department()
		{
		}

		public Department(int departmentId, string departmentName, string departmentCode, string departmentLocation):this()
		{
			DepartmentId = departmentId;
			DepartmentName = departmentName;
			DepartmentCode = departmentCode;
			DepartmentLocation = departmentLocation;
		}

		public int DepartmentId { set; get; }
		public string DepartmentName { set; get; }
		public string DepartmentCode { set; get; }
		public string DepartmentLocation { set; get; }
	}
}