using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        //Method to capture user input of integer with validation
        static int GetInteger(string prompt)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    int x = int.Parse(input);
                    if (x >= 1)
                    {
                        return x;
                    }
                    else
                    {
                        Console.WriteLine("Error: Please enter a valid positive integer.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: Please enter a valid positive integer.");
                }
            }
        }


        static void Main(string[] args)
        {
            //Get user input
            int input = GetInteger("Which digit of the Fibonacci Sequence would you like to know? (Please enter a positive integer)");

            //Create list of Fib Numbers, enter first 2
            List<int> FibNum = new List<int>();
            FibNum.Add(0);
            FibNum.Add(1);

            //Build out FibNum List to proper amount of digits, per user input
            if (input > 2)
            {
                for ( var i = 0; i < input-2; i++)
                {
                    FibNum.Add(FibNum[0+i] + FibNum[1+i]);
                }
            }

            //Report findings to Console
            Console.WriteLine("The #" + input + " digit in the Fibonacci Sequence is: " + FibNum[input - 1] + ".");
            Console.WriteLine("The Entire Fibonacci Sequence up to the #" + input + " digit is:");
            if (input == 1)
            {
                Console.WriteLine(FibNum[0]);
            }
            else
            {
                foreach (int x in FibNum)
                {
                    Console.WriteLine(x);
                }
            }
            //Hold Console Open
            Console.ReadLine();

        }
    }
}
