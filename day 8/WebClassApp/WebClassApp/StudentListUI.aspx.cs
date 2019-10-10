using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClassApp
{
    public partial class StudentListUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            List<Student> studentList=new List<Student>();
            Student aStudent=new Student();
         
            aStudent.FirstName = firstNameTextBox.Text;
            aStudent.LastName = lastNameTextBox.Text;
            aStudent.UserName = userNameTextBox.Text;
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Age = Convert.ToInt32(ageTextBox.Text);
            if (ViewState["AllStudent"] != null)
            {
                studentList = (List<Student>)ViewState["AllStudent"];
            }
            studentList.Add(aStudent);
            ClearMethod();
            ViewState["AllStudent"] = studentList;


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
            List<Student> studentList=new List<Student>();
            studentList = (List<Student>) ViewState["AllStudent"];
            foreach (Student data in studentList)
            {
                ListBox1.Items.Add("First Name: "+data.FirstName);
                ListBox1.Items.Add("Last Name: "+data.LastName);
                ListBox1.Items.Add("User Name: "+data.UserName);
                ListBox1.Items.Add("Reg No.: "+data.RegNo);
                ListBox1.Items.Add("Email: "+data.Email);
                ListBox1.Items.Add("Age: "+data.Age);
                ListBox1.Items.Add("Full Name: "+data.GetFullName());
                ListBox1.Items.Add(" ");


          
            }
        }
    }
}