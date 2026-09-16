using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System_Recap.Entities
{
    internal abstract class Account
    {
        private  int _id;
        private  decimal     _balance;
        private string _accountHolderName;
        public Account( string accountHolderName) { 
               Random  randomID = new Random();
               _id = randomID.Next(1000, 9999);
               _balance = 0;
               _accountHolderName = accountHolderName;

        }
        public void depositMoney(decimal amount) { 
           
            _balance += amount;
        }

        public void withdrawMoney(decimal amount) { 
            _balance -= amount;
        }
        public decimal getBalance()
        {
            return _balance;
        }

        public virtual string welcomeMessage() {

            return "Welcome " + _accountHolderName;
        }

    }
}
