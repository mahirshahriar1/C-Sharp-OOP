using System;


namespace project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Message myMessage = new Message("Hello");
            //myMessage.Print();
            ////Class object_name

            //Message xD = new Message("anything and everything");
            //xD.Print();

            Message myMessage = new Message("Hello World");
            myMessage.Print();

            // int[] arr = new int[5];

            Message[] messages = new Message[5];
            
            messages[0] = new Message("Hi");
            messages[1] = new Message("Hello");
            messages[2] = new Message("Tata");
            messages[3] = new Message("Byebye");
            messages[4] = new Message("Ciao");

            Console.Write("Enter name: ");
            string name=Console.ReadLine();

            //MAHIR Mahir MahiR -> to lower ()-> mahir
            if (name.ToLower() == "mahir")
            {
                messages[0].Print();
            }
            else if (name.ToLower() == "alvee")
            {
                messages[1].Print();
            }
            else if (name.ToLower() == "lihanur")
            {
                messages[2].Print();
            }
            else if(name.ToLower() == "ashraf")
            {
                messages[3].Print();
            }
            else if (name.ToLower() == "atiqur")
            {
                messages[4].Print();
            }
            else
            {
                Console.WriteLine("That is a silly name");
            }


        }
    }
}

