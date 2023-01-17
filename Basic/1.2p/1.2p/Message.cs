using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Message
    {
        private string _text;
        //constructor
        //constructor is used to initialize Class variables
        
        //public Message()
        //{
        //    _text = "";
        //}
        public Message(string text)
        {
            _text= text;
        }

        public void Print()
        {
            Console.WriteLine( _text );
        }


    }
}
