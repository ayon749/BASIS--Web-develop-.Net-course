using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nameAdd
{
	public partial class Add : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void addButton_Click(object sender, EventArgs e)
		{
			ViewState["Name"] = nameTextBox.Text;

		}

		protected void showButton_Click(object sender, EventArgs e)
		{
			shownName.Text = ViewState["Name"].ToString();
		}
	}
}