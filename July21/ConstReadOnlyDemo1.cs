using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.July21
{
    internal class ConstReadOnlyDemo1
    {
        public const int Value = 10;
        public readonly int Value1;
        
        public ConstReadOnlyDemo1(int Value)
        {
            Value1 = Value;
        }

        static void Main(string[] args)
        {
            ConstReadOnlyDemo1 CR = new ConstReadOnlyDemo1(21);
            Console.WriteLine(Value);
            Console.WriteLine(CR.Value1);
        }
    }


    class Demo
    {
        static void Main(string[] args)
        {
            int x = 8, y = 16, c = 64;
            x /= c /= y;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(c);
        }
    }
}
