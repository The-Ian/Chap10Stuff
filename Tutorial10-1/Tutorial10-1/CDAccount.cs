using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial10_1
{
    class CDAccount : SavingsAccount
    {
        private string _matDate;

        public CDAccount()
        {
            _matDate = "";
        }

        public string MatDate
        {
            get { return _matDate; }
            set { _matDate = value; }
        }
    }
}
