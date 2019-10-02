using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionayUI
{
    
    public partial class Form1 : Form
    {
        private Dictionary<int,string> detailInfo=new Dictionary<int, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            detailInfo.Add(Convert.ToInt32(idTextBox.Text),detailTextBox.Text);
            idTextBox.Text = "";
            detailTextBox.Text = "";

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string showDetail= detailInfo[Convert.ToInt32(searchIdTextBox.Text)];
            if (showDetail != null)
            {
                MessageBox.Show(showDetail);
            }
            else
            {
                MessageBox.Show("Id not found");
            }

           
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var detail in detailInfo)
            {
                sb.AppendFormat("{0} {1}{2}", detail.Key,detail.Value, Environment.NewLine);
            }

            string result = sb.ToString().TrimEnd();//when converting to string we also want to trim the redundant new line at the very end
            MessageBox.Show(result);
        }
    }
}
