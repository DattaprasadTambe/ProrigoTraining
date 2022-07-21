using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.July19
{
    
    internal class FactorialDelegate
    {
        public delegate int Fact(int a);
        public static int Factorial(int a)
        {
            int f = 1;
            for(int i=1;i<=a; i++)
            {
                f = f * i;  
            }
            return f;
        }

        static void Main(string[] args)
        {
            Fact f = Factorial;
            int c = f(5);
            Console.WriteLine("Factorial is : "+c);
        }
    }
}
