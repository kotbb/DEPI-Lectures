using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal struct Account
    {


        private int _accountId;
        private string _accountHolder;
        private decimal _balance;

        public int AccountId
        {
            get { return _accountId; } 
            set { _accountId = value; } 
        }

        public string AccountHolder
        {
            get { return _accountHolder; }
            set { _accountHolder = value; }
        }

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public Account(int id, string holder, decimal balance)
        {
            _accountId = id;
            _accountHolder = holder;
            _balance = balance;
        }

    }
}
