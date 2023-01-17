﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterTask
{
    public class Counter
    {
        private int _count;
        private string _name;     

        
        public Counter(string name)
        {
            _name = name;
            _count = 0;
        }
       

        public void Increment()
        {
            _count++;
            //_count = _count + 1;
            //_count += 1;
        }

        public void Reset()
        {
            _count = 0;
        }

        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Ticks
        {
            get
            {
                return _count;
            }
        }


    }
}
