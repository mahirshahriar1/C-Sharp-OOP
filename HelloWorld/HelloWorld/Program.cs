using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(String[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.ReadLine();
            Message myMessage = new Message("Hello");
            myMessage.print();

            Message[] arr =new Message[5];
            arr[0] = new Message("Hi");
            arr[1] = new Message("Hie");
            arr[2] = new Message("Hello");
            arr[3] = new Message("Bye");
            arr[4] = new Message("Ciao");

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            if (name.ToLower() == "mahir")
            {
                arr[0].print();
            }
            else if (name.ToLower() == "ha")
            {
                arr[1].print();
            } 
            else if (name.ToLower() == "ta")
            {
                arr[2].print();
            } 
            else if (name.ToLower() == "da")
            {
                arr[3].print();
            } 
            else if (name.ToLower() == "haha")
            {
                arr[4].print();
            } 
            else
            {
                Console.WriteLine("Invalid Name");
            }


        }
    }
}