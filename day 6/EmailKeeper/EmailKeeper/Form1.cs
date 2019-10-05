using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailKeeper
{
    public partial class Form1 : Form
    {
        private List<string> emailList=new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            string email = emailAddTextBox.Text;
            bool isValid = IsEmailValid(email);
           
            if (isValid)
            {
                emailList.Add(email);
                addEmailListBox.Items.Add(email);


            }
            else
            {
                MessageBox.Show("Email must contain a '.' and '@'");
            }

            emailAddTextBox.Text = "";

        }

        static bool IsEmailValid(string email)
        {

            bool isValid = false;
            int count = 0;
            foreach (char x in email)
            {
                if (x =='@')
                {
                    count += 1;
                }
            }
            if (email == String.Empty)
            {
                return isValid = false;
            }
            else if (email.Contains(".") && count==1)
            {
                return isValid = true;
            }
            else
            {

              return  isValid = false;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            searchEmailListBox.Items.Clear();
            string email = emailSearchTextBox.Text;
            
            if (email.Length==0)
            {
                MessageBox.Show("you must enter a letter!!!");
            }
            else
            {

                List<string> searchemails = ShowSearcEmail(email, emailList);
                if (searchemails.Count == 0)
                {
                    MessageBox.Show("Email not found.");
                }
                else
                {
                    foreach (string emails in searchemails)
                    {
                        searchEmailListBox.Items.Add(emails);
                    }
                }

                searchemails.Clear();
               
            }

            emailSearchTextBox.Text = "";

        }

        static List<string> ShowSearcEmail(string searchMail,List<string>eList)
        {
            List<string> searchEmailList = new List<string>();
            foreach (string items in eList)
            {
                
                int isNameInList = 0;
                
                if (searchMail == items)
                {
                    isNameInList = 1;

                }
                else
                {


                    foreach (char c in items)
                    {
                        if (searchMail.Contains(c))
                        {
                            isNameInList = 1;
                            break;
                        }
                        else
                        {
                            isNameInList = 0;
                        }
                    }
                }

                if (isNameInList == 1)
                {
                    searchEmailList.Add(items);
                }
                
            }

            return searchEmailList;

        }
    }
}
