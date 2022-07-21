using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.July21
{
    internal class RefOutDemo1
    {

        public static void update(out int a)
        {
            a = 10;
        }
        public static void change(ref int c)
        {
            c = 11;
        }
        public static void withoutRefOut(int a)
        {
            a = 21;
        }
        public static void Main()
        {
            int a;
            int c = 10;
            int d = 11;
            update(out a);
            change(ref c);
            withoutRefOut(d);
            Console.WriteLine("Updated value is: {0}", a);
            Console.WriteLine("Changed value is: {0}", c);
            Console.WriteLine("See value is: {0}", d);


        }
    }
}
