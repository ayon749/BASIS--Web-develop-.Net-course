using InformationManagementApp.DAL;
using InformationManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformationManagementApp.BLL
{
	public class DepartmentManager
	{
		GatewayDepartment gatewayDepartment = new GatewayDepartment();
		public List<Department> GetDepartmentName()
		{
			List<Department> departments = new List<Department>();
			departments = gatewayDepartment.GetAllDepartment();
			return departments;

		}
	}
}