using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System_Recap.Entities
{
    internal class Check : Account
    {
        public Check( string accountHolderName) : base( accountHolderName)
        {
        }
        public override string welcomeMessage()
        {
            return base.welcomeMessage() + " on opening your Check account";
        }
    
    }
}
