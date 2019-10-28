using InformationManagementApp.BLL;
using InformationManagementApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InformationManagementApp
{
	public partial class StudentEnrolledCourseUI : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			ShowAllStudentEnrolledList();

		}

		private void ShowAllStudentEnrolledList()
		{
			EnrolledManager enrolled = new EnrolledManager();
			List<StudentWiseCourseEnrolledViewModel> EnrollList = new List<StudentWiseCourseEnrolledViewModel>();
			EnrollList=enrolled.GetStudetnEnrolledList();
			enrolledCourseGridview.DataSource = EnrollList;
			enrolledCourseGridview.DataBind();
		}
	}
}