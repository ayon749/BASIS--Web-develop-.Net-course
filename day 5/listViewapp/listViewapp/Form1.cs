using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listViewapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            infoListView.View = View.Details;
            infoListView.GridLines = true;
            infoListView.FullRowSelect = true;

            infoListView.Columns.Add("Name");
            infoListView.Columns.Add("Contact");
            infoListView.Columns.Add("Email");

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string[] arr = new string[3];
            ListViewItem itm;
            arr[0] = nameTextBox.Text;
            arr[1] = contactTextBox.Text;
            arr[2] = emailtextBox.Text;
            itm = new ListViewItem(arr);
            infoListView.Items.Add(itm);
            nameTextBox.Text = "";
            contactTextBox.Text = "";
            emailtextBox.Text = "";

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            infoListView.Clear();
            infoListView.View = View.Details;
            infoListView.GridLines = true;
            infoListView.FullRowSelect = true;

            infoListView.Columns.Add("Name");
            infoListView.Columns.Add("Contact");
            infoListView.Columns.Add("Email");
        }

        private void infoListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (infoListView.SelectedItems != null)
            {
                MessageBox.Show(
                    infoListView.SelectedItems[0].SubItems[0].Text+" "+ infoListView.SelectedItems[0].SubItems[1].Text+" "+ infoListView.SelectedItems[0].SubItems[2].Text);


            }
                
        }
    }
}
