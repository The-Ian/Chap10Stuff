using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10CarDemo
{
    class Car : Automobile
    {
        private int _doors;

        public Car()
        {
            _doors = 0;
        }

        public int Doors
        {
            get { return _doors; }
            set { _doors = value; }
        }
    }
}
