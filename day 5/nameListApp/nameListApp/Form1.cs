using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nameListApp
{
    public partial class Form1 : Form
    {
         private List<int> numberList = new List<int>();
         private int size;
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           
            numberList.Add(Convert.ToInt32(nameTextBox.Text));
            size = numberList.Count;

            ClearField();
        }

        void ClearField()
        {
            nameTextBox.Text = "";
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            double sum = 0;

    
            foreach (int number in numberList)
            {
                nameListBox.Items.Add(number);
                sum = sum + number;

            }

            showTotalTextBox.Text = Convert.ToString(size);
            sumShowTextBox.Text = Convert.ToString(sum);

        }
    }
}
