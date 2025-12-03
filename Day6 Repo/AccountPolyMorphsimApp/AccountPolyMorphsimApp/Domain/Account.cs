using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolyMorphsimApp.Domain
{
   abstract class Account
    {
        private int _accno;
        private string _name;
        protected double _balance;

        public  Account(int accno, string name, double balance)
        {
            _accno = accno;
            _name = name;
            _balance = balance;
        }

        //must  be overriden in child  class
        public abstract void Withdraw(double amount);

        public void Deposit(double amount) {
            _balance += amount;
        }

        public double Balance { get { return _balance; } }
        public string Name
        {
            get { return _name; }
        }
        public int Accno
        {
            get { return _accno; }
        }

    }
}
