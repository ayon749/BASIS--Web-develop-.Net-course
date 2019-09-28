using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personalinforApp
{
    public partial class Form1 : Form
    
    {
        private string firstName,lastName,fathersName,mothersName,address;

        public Form1()
        {
            InitializeComponent();
        }

        private void savetextButton_Click(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            fathersName = fathersNameTextBox.Text;
            mothersName = mothersNametextBox.Text;
            address = addresstextBox.Text;
            MessageBox.Show("Information Saved");
            ClearTextBox();

        }

        private void showAllInformationTextBox_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            fathersNameTextBox.Text = fathersName;
            mothersNametextBox.Text = mothersName;
            addresstextBox.Text = address;

        }

    

        private void nameTextBox_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;

        }

        private void parentsNameTextBox_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            fathersNameTextBox.Text = fathersName;
            mothersNametextBox.Text = mothersName;
        }

        private void addressTextBox_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            addresstextBox.Text = address;
        }

        private void ClearTextBox()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            fathersNameTextBox.Clear();
            mothersNametextBox.Clear();
            addresstextBox.Clear();
        }

    }
}
