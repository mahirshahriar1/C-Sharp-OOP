using System;


public class Program
{
    static string name(string x)
    {
        string s="xyz";
        //Console.WriteLine( s +"->function");
        return (x+s);
    }
    static void increment(int val)
    {
        val++;
        Console.WriteLine(val);
    }
    static int increment2(int val)
    {
        val++;
        return val;
    }
    static void printArray(int[] arr)
    {        
        foreach(int n in arr)
        {
            Console.Write(n+" ");
        }
        Console.WriteLine(); //for printing a new line
    }
    static void changeArray(int[] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i]++; //incrementing array values
        }
    }
    public static void Main()
    {
        // we cant change a variable's value in a function but we can
        // change array values

        //Console.WriteLine(name("abc"));
        //int num = 5;
        //increment(num);
        //num=increment2(num);
        //Console.WriteLine(num);

        int[] arr = new int[5];
        //0 1 2 3 4 
        for (int i = 1; i <= 5; i++)
        {
            arr[i-1] = i * i;
        }

        printArray(arr);

        int[] arr2 = new int[7];        
        for (int i = 1; i <= 7; i++)
        {
            arr2[i - 1] = i ;
        }

        printArray(arr2);
        changeArray(arr2);
        printArray(arr2);



        //Console.Write("Hello");// print without \n
        //Console.WriteLine("hello world"); //print line
        //Console.Write("Hello");
        //Console.WriteLine();

        //string str = "Hi my name is Mahir";
        //Console.WriteLine(str);
        //str = str + " and i live in dhaka"; //string adding
        //Console.WriteLine(str);

        //string input;
        //input = Console.ReadLine();
        //Console.WriteLine(input); //string read

        //int integer = Convert.ToInt32(Console.ReadLine()); //integer input
        //Console.WriteLine(integer);

        //Console.WriteLine("The integer that was the input is " + integer + " blabla\n" + str); //print

        //ctrl + k + u (uncomment)
        //ctrl + k + c (comment)

        //for (int i = 0; i < 4; i++)
        //{
        //     Console.WriteLine(i);
        //}

        //int[] arr= new int[5]; //array syntax

        //for (int i = 0; i < 5; i++)
        //{            
        //    arr[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine(arr[i]);
        //}

        //for each
        //foreach(int num in arr)
        //{
        //    Console.WriteLine(num);
        //}

        //string temp = "blabla";
        //foreach(char c in temp)
        //{
        //    Console.Write(c);
        //}



    }
}