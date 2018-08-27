using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial10_1
{
    class SavingsAccount
    {
        private string _accNumber;
        private decimal _interestRate;
        private decimal _balance;

        public SavingsAccount()
        {
            _accNumber = "";
            _interestRate = 0;
            _balance = 0;
        }

        public string AccNumber
        {
            get { return _accNumber; }
            set { _accNumber = value; }
        }

        public decimal InterestRate
        {
            get { return _interestRate; }
            set { _interestRate = value; }
        }

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
    }
}
