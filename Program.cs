using System;

namespace cs_playground
{
    using PrintLine;
    using Fibonacci;
    using PrimeNumberExt;

    class Program
    {
        static void Main(string[] args)
        {
            string choice_str;
            Console.WriteLine("[0] Exit, [1] Fibonacci, [2] IsPrimeNumber, [3] WIP...");
            Console.Write("Enter your choice here --> ");
            choice_str = Console.ReadLine();
            int choice = Int32.Parse(choice_str);
            PrintLine pl = new PrintLine();
            switch (choice)
            {
                case 1:
                    Fibonacci fibo = new Fibonacci();
                    fibo.GetFibonacciSeries();
                    break;
                case 2:
                    PrimeNumber pn = new PrimeNumber();
                    Console.Write("Enter the number you want to check --> ");
                    string n_str = Console.ReadLine();
                    int n = Int32.Parse(n_str);
                    pn.IsPrimeNumber(n);
                    break;
                default:
                    break;
            }
            pl.PrintExitMessage();
        }
    }
}