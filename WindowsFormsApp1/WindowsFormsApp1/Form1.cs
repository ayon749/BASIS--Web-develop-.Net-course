using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Calculator : Form
	{
		public Calculator()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			EquationSelectComboBox();
		}

		private void EquationSelectComboBox()
		{
			equationSelectComboBox.Items.Add("Total P+I (A)");
			equationSelectComboBox.Items.Add("Principal (P)");
			equationSelectComboBox.Items.Add("Rate (R)");
			equationSelectComboBox.Items.Add("Time Period (t)");
			yearlable2.Visible = false;


		}

		private void equationSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string item = equationSelectComboBox.Text;
			if (item == "Total P+I (A)")
			{
				ChangeLabelText(1);
			}
			else if (item == "Principal (P)")
			{
				ChangeLabelText(2);

			}
			else if (item == "Rate (R)")
			{
				ChangeLabelText(3);
			}
			else
			{
				ChangeLabelText(4);
			}
		}
			void ChangeLabelText(int flag)
			{
				if (flag == 1)
				{
				yearLabel.Visible = true;
				timeComboBox.Visible = true;
				yearlable2.Visible = false;
					selectedItemShowLabel.Text = "Where: A = P(1 + rt)";
					principalLabel.Text = "Principal (P): $";
					principalTextBox.Text = "amount";
					rateLabel.Text = "Rate (R): %";
					rateTeextBox.Text = "rate";
					timeLabel.Text = "Time (t): ";
					timeTextBox.Text = "#";
					answerTextBox.Text = "Answer:";
					answerTextBox.AppendText("\r\n");
					answerTextBox.AppendText("  \r\n                                     A=?");
				}
				else if (flag == 2)
				{
				yearlable2.Visible = false;
				yearLabel.Visible = true;
				timeComboBox.Visible = true;
				selectedItemShowLabel.Text = "Where: P = A / (1 + rt)";
					principalLabel.Text = "Total P+I (A): $";
					principalTextBox.Text = "total amount";
					rateLabel.Text = "Rate (R): %";
					rateTeextBox.Text = "rate";
					timeLabel.Text = "Time (t): ";
					timeTextBox.Text = "#";
					answerTextBox.Text = "Answer:";
					answerTextBox.AppendText("\r\n");
					answerTextBox.AppendText("  \r\n                                     P=?");
				}
				else if (flag == 3)
				{
				yearlable2.Visible = false;
				yearLabel.Visible = false;
				timeComboBox.Visible = true;
					selectedItemShowLabel.Text = "Where: r = (1/t)(A/P - 1)";
					principalLabel.Text = "Total P+I (A): $";
					principalTextBox.Text = "total amount";
					rateLabel.Text = "Principal (P): $";
					rateTeextBox.Text = "amount";
					timeLabel.Text = "Time (t): ";
					timeTextBox.Text = "#";
					answerTextBox.Text = "Answer:";
					answerTextBox.AppendText("\r\n");
					answerTextBox.AppendText("  \r\n                                     R=?");

				}
				else if (flag == 4)
				{
				yearlable2.Visible = true;
				yearLabel.Visible = false;
				timeComboBox.Visible = false;
					selectedItemShowLabel.Text = "Where: t = (1/r)(A/P - 1)";
					principalLabel.Text = "Total P+I (A): $";
					principalTextBox.Text = "total amount";
					rateLabel.Text = "Principal (P): $";
					rateTeextBox.Text = "amount";
					timeLabel.Text = "Rate (R): %";
					timeTextBox.Text = "rate";
					answerTextBox.Text = "Answer:";
					answerTextBox.AppendText("\r\n");
					answerTextBox.AppendText("\r\n                                     t=?");
				}


		     }

		private void calculateButton_Click(object sender, EventArgs e)
		{
			string equation = equationSelectComboBox.Text;
			if (equation == "Total P+I (A)")
			{
				double rateYear = Convert.ToDouble(rateTeextBox.Text);
				double rateYearPercent = rateYear / 100;
				double time = Convert.ToDouble(timeTextBox.Text);
				if (timeComboBox.Text == "days(365/Yr)")
				{
					time = time / 365;
				}
				else if (timeComboBox.Text == "days(360/Yr)")
				{
					time = time / 360;
				}
				else if (timeComboBox.Text == "weeks")
				{
					time = time / 52;
				}
				else if (timeComboBox.Text == "months")
				{
					time = time / 12;

				}
				else if (timeComboBox.Text == "quarters")
				{
					time = time / 4;
				}
				double principle = Convert.ToDouble(principalTextBox.Text);
				double amount = principle * (1 + (rateYearPercent * time));
				double interest = amount - principle;
				answerTextBox.Text = "Answer: ";
				string interestToText = "(I=A-P=$" + interest + ")";
				string amountToText = "A =$" + amount;
				answerTextBox.AppendText("\r\n                                         " + amountToText);
				answerTextBox.AppendText("\r\n                                 " + interestToText);
				answerTextBox.AppendText("\r\n");
				answerTextBox.AppendText("\r\n                                        Equation:");
				answerTextBox.AppendText("\r\n                                       A = P(1+rt)");
				answerTextBox.AppendText("\r\n Calculation: ");
				string firstline = "First, converting R percent to r a decimal r = R/100= " + rateYear + "%/100= " + rateYearPercent + " per year.";

				answerTextBox.AppendText("\r\n" + firstline);
				if (timeComboBox.Text == "days(365/Yr)")
				{
					String secondLine = "Putting time into years for simplicity,";
					answerTextBox.AppendText("\r\n" + secondLine);
					string thirdLine = timeTextBox.Text + "/ 365 days/year = " + time + " years.";
					answerTextBox.AppendText("\r\n" + thirdLine);


				}
				else if (timeComboBox.Text == "days(360/Yr)")
				{
					String secondLine = "Putting time into years for simplicity,";
					answerTextBox.AppendText("\r\n" + secondLine);
					string thirdLine = timeTextBox.Text + "/ 360 days/year = " + time + " years.";
					answerTextBox.AppendText("\r\n" + thirdLine);

				}
				else if (timeComboBox.Text == "weeks")
				{
					String secondLine = "Putting time into years for simplicity,";
					answerTextBox.AppendText("\r\n" + secondLine);
					string thirdLine = timeTextBox.Text + "/ 52 weeks/year = " + time + " years.";
					answerTextBox.AppendText("\r\n" + thirdLine);


				}
				else if (timeComboBox.Text == "months")
				{
					String secondLine = "Putting time into years for simplicity,";
					answerTextBox.AppendText("\r\n" + secondLine);
					string thirdLine = timeTextBox.Text + "/ 12 months/year = " + time + " years.";
					answerTextBox.AppendText("\r\n" + thirdLine);


				}
				else if (timeComboBox.Text == "quarters")
				{
					String secondLine = "Putting time into years for simplicity,";
					answerTextBox.AppendText("\r\n" + secondLine);
					string thirdLine = timeTextBox.Text + "/4 quarters/year = " + time + " years.";
					answerTextBox.AppendText("\r\n" + thirdLine);


				}
				string fourthLine = "The total amount accured, principal plus interest, from simple interest on a principal of $" + amount + " at a rate of " + rateYear + "% per year for " + time + " years";


			}
			else if (equation == "Principal (P)")
			{
				double rateYear = Convert.ToDouble(rateTeextBox.Text);
				double rateYearPercent = rateYear / 100;
				double time = Convert.ToDouble(timeTextBox.Text);
				if (timeComboBox.Text == "days(365/Yr)")
				{
					time = time / 365;
				}
				else if (timeComboBox.Text == "days(360/Yr)")
				{
					time = time / 360;
				}
				else if (timeComboBox.Text == "weeks")
				{
					time = time / 52;
				}
				else if (timeComboBox.Text == "months")
				{
					time = time / 12;

				}
				else if (timeComboBox.Text == "quarters")
				{
					time = time / 4;
				}
				double amount = Convert.ToDouble(principalTextBox.Text);
				double principal = amount / (1 + (rateYearPercent * time));
				double diff = principal - (int)principal;
				double principalcConverted;
				if (diff > .50)
				{
					principalcConverted = Math.Ceiling(principal);
				}
				else
				{
					principalcConverted = Math.Floor(principal);
				}
				answerTextBox.Text = "Answer: ";

				string principalTOText = "A =$" + principalcConverted;
				answerTextBox.AppendText("\r\n                                         " + principalTOText);

				answerTextBox.AppendText("\r\n                                        Equation:");
				answerTextBox.AppendText("\r\n                                      P=A/(1+rt)");
				answerTextBox.AppendText("\r\n Calculation: ");
				string firstline = "First, converting R percent to r a decimal r = R/100= " + rateYear + "%/100= " + rateYearPercent + " per year.";

				answerTextBox.AppendText("\r\n" + firstline);
				if (timeComboBox.Text == "days(365/Yr)")
				{
					String secondLine = "Putting time into years for simplicity,";
					answerTextBox.AppendText("\r\n" + secondLine);
					string thirdLine = timeTextBox.Text + "/ 365 days/year = " + time + " years.";
					answerTextBox.AppendText("\r\n" + thirdLine);


				}
				else if (timeComboBox.Text == "days(360/Yr)")
				{
					String secondLine = "Putting time into years for simplicity,";
					answerTextBox.AppendText("\r\n" + secondLine);
					string thirdLine = timeTextBox.Text + "/ 360 days/year = " + time + " years.";
					answerTextBox.AppendText("\r\n" + thirdLine);

				}
				else if (timeComboBox.Text == "weeks")
				{
					String secondLine = "Putting time into years for simplicity,";
					answerTextBox.AppendText("\r\n" + secondLine);
					string thirdLine = timeTextBox.Text + "/ 52 weeks/year = " + time + " years.";
					answerTextBox.AppendText("\r\n" + thirdLine);


				}
				else if (timeComboBox.Text == "months")
				{
					String secondLine = "Putting time into years for simplicity,";
					answerTextBox.AppendText("\r\n" + secondLine);
					string thirdLine = timeTextBox.Text + "/ 12 months/year = " + time + " years.";
					answerTextBox.AppendText("\r\n" + thirdLine);


				}
				else if (timeComboBox.Text == "quarters")
				{
					String secondLine = "Putting time into years for simplicity,";
					answerTextBox.AppendText("\r\n" + secondLine);
					string thirdLine = timeTextBox.Text + "/4 quarters/year = " + time + " years.";
					answerTextBox.AppendText("\r\n" + thirdLine);


				}
				string fourthLine = "The total investment  required to get a total amount, principal plus interest, of $" + principalcConverted + " from simple interest at a rate of " + rateYear + "% per year for " + rateYearPercent + " years ( " + timeTextBox.Text + "days) is $" + principalcConverted;


			}
			else if (equation == "Rate (R)")
			{
				double amount = Convert.ToDouble(principalTextBox.Text);
				double principal = Convert.ToDouble(rateTeextBox.Text);
				if (amount > principal)
				{
					double time = Convert.ToDouble(timeTextBox.Text);
					double rate = (1 / time) * ((amount / principal) - 1);
					double rateTOPercentege = rate * 100;
					double annualRate;
					if (timeComboBox.Text == "days(365/Yr)")
					{
						annualRate = rateTOPercentege * 365;
					}
					else if (timeComboBox.Text == "days(360/Yr)")
					{
						annualRate = rateTOPercentege * 360;
					}
					else if (timeComboBox.Text == "weeks")
					{
						annualRate = rateTOPercentege * 52;
					}
					else if (timeComboBox.Text == "months")
					{
						annualRate = rateTOPercentege * 12;

					}
					else if (timeComboBox.Text == "quarters")
					{
						annualRate = rateTOPercentege * 4;
					}
					else
					{
						annualRate = 0;
					}
					answerTextBox.Text = "Answer: ";
					string rateTText = "R =$" + rateTOPercentege + "%/month";
					answerTextBox.AppendText("\r\n                                         " + rateTText);
					string rateannuToText = "(R =$" + annualRate + "%/year)";
					answerTextBox.AppendText("\r\n                                         " + rateannuToText);
					answerTextBox.AppendText("\r\n                                        Equation:");
					answerTextBox.AppendText("\r\n                                      r=(1/t)(A/P-1)");
					answerTextBox.AppendText("\r\n Calculation: ");
					string firstline = "Solving our equations: ";
					answerTextBox.AppendText("\r\n" + firstline);
					string secondline = "r =( 1/" + time + ")(( " + amount + "/" + principal + "- 1) =" + rate;
					answerTextBox.AppendText("\r\n" + secondline);
					string thirdline = "r = " + rate;
					answerTextBox.AppendText("\r\n" + thirdline);
					if (timeComboBox.Text == "days(365/Yr)")
					{
						String fourthline = "Calculating the annual rate ";
						answerTextBox.AppendText("\r\n" + fourthline);
						string fifthline = rateTOPercentege + "%/365/year * 365 days/year=";

						answerTextBox.AppendText("\r\n" + fifthline);
						string sixthline = annualRate + "%/year";
						answerTextBox.AppendText("\r\n" + sixthline);


					}
					else if (timeComboBox.Text == "days(360/Yr)")
					{
						String fourthline = "Calculating the annual rate ";
						answerTextBox.AppendText("\r\n" + fourthline);
						string fifthline = rateTOPercentege + "%/360/year * 360 days/year=";

						answerTextBox.AppendText("\r\n" + fifthline);
						string sixthline = annualRate + "%/year";
						answerTextBox.AppendText("\r\n" + sixthline);

					}
					else if (timeComboBox.Text == "weeks")
					{
						String fourthline = "Calculating the annual rate ";
						answerTextBox.AppendText("\r\n" + fourthline);
						string fifthline = rateTOPercentege + "%/52/year * 52 weeks/year=";

						answerTextBox.AppendText("\r\n" + fifthline);
						string sixthline = annualRate + "%/year";
						answerTextBox.AppendText("\r\n" + sixthline);


					}
					else if (timeComboBox.Text == "months")
					{
						String fourthline = "Calculating the annual rate ";
						answerTextBox.AppendText("\r\n" + fourthline);
						string fifthline = rateTOPercentege + "%/12/year * 12 months/year=";

						answerTextBox.AppendText("\r\n" + fifthline);
						string sixthline = annualRate + "%/year";
						answerTextBox.AppendText("\r\n" + sixthline);


					}
					else if (timeComboBox.Text == "quarters")
					{
						String fourthline = "Calculating the annual rate ";
						answerTextBox.AppendText("\r\n" + fourthline);
						string fifthline = rateTOPercentege + "%/4/year * 4 wquarters/year=";

						answerTextBox.AppendText("\r\n" + fifthline);
						string sixthline = annualRate + "%/year";
						answerTextBox.AppendText("\r\n" + sixthline);


					}

					string sevenline = "The interest rate required to get a total amount, principal plus interest, of $" + amount + " from simple interest on a principal of $" + principal + " over " + time + "is " + rateTOPercentege + "% per unit.";


				}
				else
				{
					answerTextBox.Text = "A must be greater than P";
				}


			}
			else
			{
				double amount = Convert.ToDouble(principalTextBox.Text);
				double principal = Convert.ToDouble(rateTeextBox.Text);
				if (amount > principal)
				{
					double rate = Convert.ToDouble(timeTextBox.Text);
					double ratePerYear = rate / 100;
					double time = (1 / ratePerYear) * ((amount / principal) - 1);

					answerTextBox.Text = "Answer: ";
					string dateText = "t =" + time + " years";
					answerTextBox.AppendText("\r\n                               " + dateText);
					answerTextBox.AppendText("\r\n                                        Equation:");
					answerTextBox.AppendText("\r\n                                      t=(1/r)(A/P - 1)");
					answerTextBox.AppendText("\r\n Calculation: ");
					string firstLine = "First, converting R percent to r a decimal r=R/100=" + rate + "%/100 = " + ratePerYear + " per year,";
					answerTextBox.AppendText("\r\n" + firstLine);
					string secondline = "then, solving our equation";
					answerTextBox.AppendText("\r\n" + secondline);
					string thirdline = "t = (1/" + ratePerYear + ")((" + amount + "/" + principal + ") -" + ") = " + time;
					answerTextBox.AppendText("\r\n" + thirdline);
					string fourthline = time + " years";

				}
				else
				{
					answerTextBox.Text = "A must be greater than P";
				}
			}

		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			string item = equationSelectComboBox.Text;
			if (item== "Total P+I (A)")
			{
				ChangeLabelText(1);

			}
			else if (item == "Principal (P)")
			{
				ChangeLabelText(2);

			}
			else if (item == "Rate (R)")
			{
				ChangeLabelText(3);
			}
			else
			{
				ChangeLabelText(4);
			}
		}
	}
	}


