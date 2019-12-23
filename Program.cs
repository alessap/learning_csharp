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
            string choice;
            Console.WriteLine("[0] Exit, [1] Fibonacci, [2] IsPrimeNumber, [3] WIP...");
            Console.Write("Enter your choice here --> ");
            choice = Console.ReadLine();
            if (choice == "1"){
                Fibonacci fibo = new Fibonacci();
                fibo.GetFibonacciSeries();
                PrintLine pl = new PrintLine();
            }
            else if (choice == "2"){
                PrimeNumber pn = new PrimeNumber();
                Console.Write("Enter the number you want to check --> ");
                string n_str = Console.ReadLine();
                int n = Int32.Parse(n_str);
                pn.IsPrimeNumber(n);
                PrintLine pl = new PrintLine();
            }
            else if (choice != "1"){
                PrintLine pl = new PrintLine();
            }
        }
    }
}