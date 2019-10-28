using InformationManagementApp.DAL;
using InformationManagementApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformationManagementApp.BLL
{
	public class EnrolledManager
	{
		GatewayEnrolled gatewayEnrolled = new GatewayEnrolled();
		public List<StudentWiseCourseEnrolledViewModel> GetStudetnEnrolledList()
		{
			return gatewayEnrolled.GetEnrolledStudent();
		}
	}
}