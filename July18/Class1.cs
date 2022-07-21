using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.July18
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b;
                a = 10;
                b = 20;
                int c = a + b;
                Console.WriteLine();

            }
            catch (OverflowException e)
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
