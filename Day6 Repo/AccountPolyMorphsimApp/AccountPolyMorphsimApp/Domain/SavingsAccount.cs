using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolyMorphsimApp.Domain
{
     class SavingsAccount: Account
    {

        public SavingsAccount(int accno, string name, double balance)
            :base(accno,name,balance)
        { 
        
        }

        public override void Withdraw(double amount)
        {
            if(_balance-amount >= 500)
              _balance = _balance - amount;
        }
    }
}
