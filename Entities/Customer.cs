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


         public Customer(string id, string name, bool accountChoice) { 
             _IdNumber = id;
             _Name = name;
             

            if(accountChoice) {

               _Account= new Saving(name);
            } else
            { 
               _Account = new Check(name);
            }

        }




    }
}
