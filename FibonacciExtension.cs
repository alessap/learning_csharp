using System;

namespace Fibonacci{
    class Fibonacci {
        // # constructor
        public Fibonacci() {
        }
        // method to print fibonacci series
        public void GetFibonacciSeries(){
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
        // # desctructor
        ~Fibonacci(){}
    }
}