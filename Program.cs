using System;

namespace cs_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            Console.WriteLine("Enter 1 if you want Fibonacci series,");
            Console.Write("enter 2 if you want something else - ");
            choice = Console.ReadLine();
            if (choice == "1"){

                Console.WriteLine("Hello World! This is the beginning of Fibonacci's series");

                string limit_str;
                Console.Write("Enter the length of the series - ");
                limit_str = Console.ReadLine();
                Console.WriteLine("You entered '{0}'", limit_str);

                int limit = Int32.Parse(limit_str);
                int[] arr = new int[limit];
                arr[0] = 0;
                arr[1] = 1;

                for (int i = 2; i < limit; i++){
                    arr[i] = arr[i-1] + arr[i-2] ;
                }

                for (int i = 0; i < limit; i++){
                    Console.WriteLine(arr[i] + " ");
                }
            }
            else if (choice != "1"){
                Console.WriteLine("Something else");
            }
        }
    }
}