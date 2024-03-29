﻿using System;
using SplashKitSDK;

namespace Counter
{
    public class MainClass
    {
        private static void PrintCounters(Counter[] counters)
        {            
            foreach (Counter c in counters)
            {
                //Console.WriteLine("Hello {0}{1}", "World", "!");
                Console.WriteLine("{0} is {1}", c.Name,c.Value);    
               // Console.WriteLine(c.Name+" is "+ c.Value);
            }
        }

        public static void Main(string[] args)
        {
            
            Counter[] myCounters = new Counter[3];            

            myCounters[0] = new Counter("Counter 1");
            myCounters[1] = new Counter("Counter 2");
            myCounters[2] = myCounters[0];
        
            for (int i = 0; i < 9; i++)
            {
                myCounters[0].Increment();
            }
            for (int i = 0; i < 14; i++)
            {
                myCounters[1].Increment();
            }

            PrintCounters(myCounters);

            myCounters[2].Reset();
            PrintCounters(myCounters);
           
        }
    }
}
