using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.July20
{

    public delegate bool myPrime(int a);
    internal class IsPrimeDelegate
    {
        //public static bool isPrime(int a)
        public static myPrime mp = (a) =>
        {
            bool prime = true;
            for (int i = 2; i <= a/2; i++)
            {
                if (a % i == 0)
                {
                    prime = false; break;
                }
            }
            if(prime == true)
            return true;
            else
                return false;
        };

        static void Main(string[] args)
        {
            bool primeornot = mp(7);
            Console.WriteLine(primeornot);
        }
    }
}





//fun delegte
//action delegate