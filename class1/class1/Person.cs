using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public class Person
    {
        private string _name, _address;
        private int _age;
        public Person(string name,int age ,string address)
        {
            _age = age;
            _address = address;
            _name = name;
        }

        public string info()
        {
            return (_name + " " + _age + " " + _address);
        }
    }
}
