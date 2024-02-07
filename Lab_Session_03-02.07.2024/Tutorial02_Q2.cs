using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial02_Q2
{
    public class BankAccount
    {
        private string accountNumber;
        private double balance;

        // Constructor
        public BankAccount(string accountNumber, double initialBalance)
        {
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
        }

        // Method to deposit money into the account
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid deposit amount. Amount must be greater than zero.");
                return;
            }

            balance += amount;
            Console.WriteLine($"Deposited ${amount}. New balance: ${balance}");
        }

        // Method to get the account number
        public string GetAccountNumber()
        {
            return accountNumber;
        }

        // Method to get the balance
        public double GetBalance()
        {
            return balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a bank account object with an initial balance
            BankAccount myAccount = new BankAccount("1234567890", 1000);

            // Deposit some money into the account
            myAccount.Deposit(500);

            // Deposit a negative amount (invalid deposit)
            myAccount.Deposit(-200);

            // Display the current balance
            Console.WriteLine($"Current balance of account {myAccount.GetAccountNumber()}: ${myAccount.GetBalance()}");
        }
    }
}
