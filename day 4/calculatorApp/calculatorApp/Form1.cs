using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addNumber_Click(object sender, EventArgs e)
        {
            bool isTrue = ISEmpty(firstNumberBox.Text, secondNumberBox.Text);
            if (isTrue==false)
            {
                MessageBox.Show("You need to fill the  text field!");
             
            }
            
            else
            { 
                int firstNumber = Convert.ToInt32(firstNumberBox.Text);
                int secondNumber = Convert.ToInt32(secondNumberBox.Text);
                int sum = firstNumber + secondNumber;
                resultBox.Text = Convert.ToString(sum);
            }

        }

        private void subNumber_Click(object sender, EventArgs e)
        {
            bool isTrue = ISEmpty(firstNumberBox.Text, secondNumberBox.Text);
            if (isTrue == false)
            {
                MessageBox.Show("You need to fill the  text field!");

            }

            else
            {
                int firstNumber = Convert.ToInt32(firstNumberBox.Text);
                int secondNumber = Convert.ToInt32(secondNumberBox.Text);
                int sub = firstNumber - secondNumber;
                resultBox.Text = Convert.ToString(sub);
            }
        }

        private void mulNumber_Click(object sender, EventArgs e)
        {
            bool isTrue = ISEmpty(firstNumberBox.Text, secondNumberBox.Text);
            if (isTrue == false)
            {
                MessageBox.Show("You need to fill the  text field!");

            }

            else
            {
                int firstNumber = Convert.ToInt32(firstNumberBox.Text);
                int secondNumber = Convert.ToInt32(secondNumberBox.Text);
                int mul = firstNumber * secondNumber;
                resultBox.Text = Convert.ToString(mul);
            }
        }

        private void divNumber_Click(object sender, EventArgs e)
        {
            bool isTrue = ISEmpty(firstNumberBox.Text, secondNumberBox.Text);
            if (isTrue == false)
            {
                MessageBox.Show("You need to fill the  text field!");

            }

            else
            {

                int firstNumber = Convert.ToInt32(firstNumberBox.Text);
               
                int secondNumber = Convert.ToInt32(secondNumberBox.Text);
                if (secondNumber == 0)
                {
                    MessageBox.Show("Second Number can not be 0!!!");
                }
                else
                {
                    double div = (double)firstNumber / (double)secondNumber;
                    resultBox.Text = Convert.ToString(div);
                }
            }
        }

        private bool ISEmpty(string firstNumber, string lastNumber)
        {
            if (firstNumber == string.Empty)
            {
                return false;
            }
            else if (lastNumber == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
