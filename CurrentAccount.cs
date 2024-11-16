using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banque
{
    public class CurrentAccount
    {

        public required string Number { get; set; }
        public double Balance { get; private set; }
        public double CreditLine{ get; private set; }
        public Person Owner { get; private set; }




        public CurrentAccount(string number, double balance, double creditLine, Person owner)
        {
            Number = number;
            Balance = balance;
            CreditLine = creditLine;
            Owner = owner;
        }

        public void Withdraw(double Amount)
        {

        }

        public void Deposit(double Amount)
        {

        }
    }
}