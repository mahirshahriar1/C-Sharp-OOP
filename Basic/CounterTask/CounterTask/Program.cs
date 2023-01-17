using System;


namespace CounterTask
{
    public class Program
    {
        public static void printCounters(Counter[] counters)
        {
            foreach(Counter c in counters)
            {
                //Console.WriteLine(c.Name + " is " + c.Ticks);
                Console.WriteLine("{0} is {1}", c.Name, c.Ticks);
            }
        }
        public static void Main()
        {
            //int[] arr = new int[5]; //5 size array

            Counter[] myCounters= new Counter[3];

            myCounters[0] = new Counter("Counter 1");
            myCounters[1] = new Counter("Counter 2");
            myCounters[2] = myCounters[0]; //

            for(int i = 0; i < 9; i++)
            {
                myCounters[0].Increment();
            }
            for (int i = 0; i < 14; i++)
            {
                myCounters[1].Increment();
            }
           // myCounters[2].Increment();
    
            printCounters(myCounters);

            myCounters[2].Reset();
            printCounters(myCounters);

     

        }
    }
}