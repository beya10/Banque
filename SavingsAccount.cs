using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    public class SavingsAccount
    {
        public string Number { get; set; }
        protected double Balance { get; private set; }
        DateTime DateLastWithdraw { get; set; }
        protected  Person Owner { get; private set; }



        public SavingsAccount(string number, double balance, DateTime dateLastWithdraw, Person owner)
        {
            Number = number;
            Balance = balance;
            DateLastWithdraw = dateLastWithdraw;
            Person Owner = owner;
        }

        public void Withdraw(double Amount) 
        { 
        
        }

        public void Deposit(double Amount)
        {

        }

    }
}
