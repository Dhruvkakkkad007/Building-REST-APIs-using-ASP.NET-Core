//3.Write a program to create a BankAccount class with account number and balance. 
//Use exception handling to display an error message when the withdrawal amount exceeds the available balance.

namespace Lab_5
{
    class BankAccount
    {
        int accountNumber;
        int balance;


        public BankAccount(int accountNumber, int balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }


        public void  withdraw(int amount)
        {
            if (amount > balance)
            {
                throw new InsufficientExecutionStackException("Insufficient Balance");
            }
            balance -= amount;
            Console.WriteLine("Withdrawal successful. New balance: " + balance);
        }
        
    }
}
