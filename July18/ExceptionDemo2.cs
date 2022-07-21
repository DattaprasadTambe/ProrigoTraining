using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.July18
{
    internal class ExceptionDemo2
    {
        public static void m1(int a, int b)
        {
            Console.WriteLine("m1 starts");
            Console.WriteLine("Division: " + (a / b));
            Console.WriteLine("m1 ends");
        }

        public static void m2(int x, int y)
        {
            Console.WriteLine("m2 starts");
            m1(x, y);
            Console.WriteLine("m2 ends");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main starts");
            try
            {
                m2(10, 0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Main ends");

        }
    }
}
