using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fullname
{
	public partial class name : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void showButton_Click(object sender, EventArgs e)
		{
			string firstName = fNameTextBox.Text;
			string middleName = mNameTextBox.Text;
			string lastName = lNameTextBox.Text;
			string fullname = firstName + " " + middleName + " " + lastName;
			fullNameLabel.Text = fullname;

		}
	}
}