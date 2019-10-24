using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccountHolderInformation
{
    public partial class AccoundHolderUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createButton_Click(object sender, EventArgs e)
        {
            string accountNumber = accountNumbertextBox.Text;
            string accountName = accountNameTextBox.Text;
            Account aAccount = new Account();
            aAccount.AccountNumber = accountNumber;
            aAccount.CustomerName = accountName;
            ViewState["ACustomer"] = aAccount;
        }

        protected void depositButton_Click(object sender, EventArgs e)
        {
            Account aCustomer = new Account();
            aCustomer = (Account)ViewState["ACustomer"];
            double balance = aCustomer.Balance;
            double amount = Convert.ToInt32(amounttextBox.Text);
             aCustomer.Deposit(amount);

        }

        protected void withdrawButton_Click(object sender, EventArgs e)
        {
            Account aCustomer = new Account();
            aCustomer = (Account)ViewState["ACustomer"];
            double balance = aCustomer.Balance;
            double amount = Convert.ToInt32(amounttextBox.Text);
            aCustomer.Withdraw(amount);
            ViewState["ACustomer"] = aCustomer;
        }

        protected void reportButton_Click(object sender, EventArgs e)
        {
            Account aCustomer = new Account();
            aCustomer = (Account)ViewState["ACustomer"];
            string name = aCustomer.CustomerName;
            string aNumber = aCustomer.AccountNumber;
            Double balance = aCustomer.Balance;
            string message = name + ", you account number: " + aNumber + " and it's balance is " + balance;
            showReportLabel.Text = message;
            
        }
    }

}