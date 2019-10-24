using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountHolderInformation
{
    [Serializable]
    public class Account
    {
        
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; private set; }
        private double balance = 0;

       

        public void Deposit(double amount)
        {
            Balance= Balance + amount;
            
           
        }
        public void Withdraw(double amount)
        {
            Balance = Balance - amount;
            
        }
        public Account()
        {
            Balance = 0;
        }

    }
}