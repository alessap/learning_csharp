using System;

namespace PrimeNumberExt
{
    class PrimeNumber
    {
        public PrimeNumber(){}
        public void IsPrimeNumber(int n){
            bool prime = true;
            for (int i = n-1; i > 1; i--)
            {
                double remainder = n % i;
                // Console.WriteLine("{0} % {1} = {2}, ", n, i, remainder);
                if (remainder == 0){
                    // Console.WriteLine("{0} is NOT a prime number!", n);
                    prime = false;
                    break;
                }
            }
            if (prime){
                Console.WriteLine("{0} is a prime number!", n);
            }
            else{
                Console.WriteLine("{0} is NOT a prime number!", n);
            }
        }
        ~PrimeNumber(){}
    }
}