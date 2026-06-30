using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
     interface IPayment
    {
        public void proceesPayment(double amount);
    }

    class CreditCArdPayment : IPayment
    {
        public void proceesPayment(double amount)
        {
            if(amount < 0)
            {
                throw new Exception("Invalid Amount");
            }
            Console.WriteLine($"Processing credit card payment of {amount}");
        }
    }
}
