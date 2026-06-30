using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
     interface ITransaction
    {
        void deposit(double balance);
        void withdraw(double balance);
    }

    class BannkAccount : ITransaction
    {
        double balance;

        public BannkAccount(double balance)
        {
            this.balance = balance;
        }

        public void deposit(double balance)
        {
            balance = balance;
            Console.WriteLine("Deposit successful. New balance: " + balance);
        }

        public void withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new Exception("Enter valid salary");
            }
            balance -= amount;
            Console.WriteLine("Valid Salary:" + balance);
        }
    }
}
