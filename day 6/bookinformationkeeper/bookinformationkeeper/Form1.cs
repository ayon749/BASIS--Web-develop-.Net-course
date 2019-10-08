using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookinformationkeeper
{
    public partial class Form1 : Form
    {
        private Dictionary<string,string> bookInfo=new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            isbnradioButton.Checked = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
			string isbnTrim = isbnTextBox.Text.TrimStart();
			if (isbnTrim != string.Empty && nameTextBox.Text != string.Empty)
			{
				string isbn = isbnTextBox.Text;
				string name = nameTextBox.Text;
				bool isNotempty = BlankField(isbn, name);
				if (isNotempty)
				{
					bookInfo.Add(isbn, name);
					addlistBox.Items.Add(isbn);
					addlistBox.Items.Add(name);
					isbnTextBox.Text = "";
					nameTextBox.Text = "";
				}
				else
				{
					MessageBox.Show("You have to field all the fields!");
				}
			}
			else
			{
				MessageBox.Show("ISBN and Name field Can not be empty!!");
			}

        }

        static bool BlankField(string isbn, string name)
        {
            bool isEmpty = false;
            if (isbn == null || name==null)
            {
                isEmpty = false;

            }
            else
            {
                isEmpty = true;
            }

            return isEmpty;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
			searchListBox.Items.Clear();
			if (searchTextBox.Text != string.Empty)
			{

				if (isbnradioButton.Checked)
				{
					string isbn = searchTextBox.Text;
					if (bookInfo.ContainsKey(isbn))
					{
						searchListBox.Items.Add(bookInfo[isbn]);
					}
					else
					{
						MessageBox.Show("Enter a valid ISBN");
					}
				}
				else
				{
					string name = searchTextBox.Text;
					if (bookInfo.ContainsValue(name))
					{
						searchListBox.Items.Add(name);
					}
					else
					{
						MessageBox.Show("Book not found.");
					}

				}
			}
			else
			{
				MessageBox.Show("Enter a valid keyword.");
			}

            searchTextBox.Text = "";
        }
    }
}
