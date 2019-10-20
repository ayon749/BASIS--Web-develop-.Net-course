using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeInformationForm.Models
{
	public class Employee
	{
		public int EmployeeId { get; set; }
		public string EmployeeName { get; set; }
		public string EmployeePosition { get; set; }
		public string EmployeeMobileNo { get; set; }
		public string EmployeeEmail { get; set; }
		public int EmployeeSalary { get; set; }
		public int EmployeeAge { get; set; }
		public string EmployeeAddress { get; set; }

		public Employee(string employeeName,string employeePosition,string employeeMobileNo,string employeeEmail,int employeeSalary,int employeeAge,string employeeAddress)
		{
			EmployeeName = employeeName;
			EmployeePosition = employeePosition;
			EmployeeMobileNo = employeeMobileNo;
			EmployeeEmail = employeeEmail;
			EmployeeSalary = employeeSalary;
			EmployeeAge = employeeAge;
			EmployeeAddress = employeeAddress;
		}
		public Employee(int employeeId)
		{
			EmployeeId = employeeId;
		}
	}
}