using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System_Recap.Entities
{
    internal class Customer
    {
        private string _IdNumber;
        private string _Name;
        private Account _Account;


        public Customer(string id, string name, bool accountChoice)
        {
            _IdNumber = id;
            _Name = name;

            if (accountChoice)
            {
                _Account = new Saving(name);
            }
            else
            {
                _Account = new Check(name);
            }
        }


        public void Deposit(decimal amount)
        {
            if (_Account is Saving savingAccount)
            {
                Console.WriteLine("This is a savings account");

                savingAccount.depositMoney(amount);
            }
            else if (_Account is Check checkingAccount)
            {
                Console.WriteLine("This is a checking account");

                checkingAccount.depositMoney(amount);
            }
        }


        public void Withdraw(decimal amount)
        {
            if (_Account is Saving savingAccount)
            {
                Console.WriteLine("Withdrawing from savings account");

                savingAccount.withdrawMoney(amount);
            }
            else if (_Account is Check checkingAccount)
            {
                Console.WriteLine("Withdrawing from checking account");

                checkingAccount.withdrawMoney(amount);
            }
        }


        public void displayCustomerInfo()
        {
            Console.WriteLine("Account Number: " + _Account.getAccountNumber());
            Console.WriteLine("Customer ID: " + _IdNumber);
            Console.WriteLine("Customer Name: " + _Name);
            Console.WriteLine(_Account.welcomeMessage());
            Console.WriteLine("Balance: R" + _Account.getBalance());
        }
    }
}