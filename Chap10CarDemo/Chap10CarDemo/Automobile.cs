﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10CarDemo
{
    class Automobile
    {
        private string _make;
        private string _model;
        private int _mileage;
        private decimal _price;

        public Automobile()
        {
            _make = "";
            _model = "";
            _mileage = 0;
            _price = 0;
        }
        
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
