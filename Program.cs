using System;

namespace cs_playground
{
    using Fibonacci;
    using PrintLine;
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            Console.WriteLine("Enter 1 if you want Fibonacci series,");
            Console.Write("enter 2 if you want something else - ");
            choice = Console.ReadLine();
            if (choice == "1"){
                Fibonacci fibo = new Fibonacci();
                fibo.GetFibonacciSeries();
            }
            else if (choice != "1"){
                PrintLine pl = new PrintLine();
            }
        }
    }
}