using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClassApp
{
    public partial class StudentInfoUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent=new Student();
            aStudent.FirstName = firstNameTextBox.Text;
            aStudent.LastName = lastNameTextBox.Text;
            aStudent.UserName = userNameTextBox.Text;
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Age = Convert.ToInt32(ageTextBox.Text);
            ViewState["Student"] = aStudent;
            //ClearMethod();



        }

        public void ClearMethod()
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            userNameTextBox.Text = string.Empty;
            regNoTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            ageTextBox.Text = string.Empty;
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            Student viewstate = (Student) ViewState["Student"];
            if (viewstate != null)
            {
                firstNameLabel.Text = viewstate.FirstName;
                lastNameLabel.Text = viewstate.LastName;
                userNameLabel.Text = viewstate.UserName;
                regNoLabel.Text = viewstate.RegNo;
                emailLabel.Text = viewstate.Email;
                agelabel.Text = viewstate.Age.ToString();
                fullNameLabel.Text = viewstate.GetFullName();
            }
            else
            {
                messageLabel.Text = "Student Not found";
                messageLabel.ForeColor = Color.Red;
            }

        }

        protected void studentListButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentListUI.aspx");
        }
    }
}