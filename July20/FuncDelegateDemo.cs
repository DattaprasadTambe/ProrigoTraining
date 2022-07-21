using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.July20
{
    internal class FuncDelegateDemo
    {
        public static int Multi(int a,int b)
        {
            return a * b;
        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine("Subtraction: "+(a-b));
        }

        static bool isEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Func<int, int, int> mul = Multi;
            int mult = mul(2, 3);
            Console.WriteLine(mult);

            Func<int, int, int> Subtraction = (a,b) => (a-b);

            Action<int, int> d3 = (a, b) => Console.WriteLine("Addiion"+(a+b));
            d3(90, 10);

            Action<int, int> d4 = Sub;
            d4(10, 5);

            Func<int, bool> even = isEven;
            bool ev = even(23);
            Console.WriteLine(ev);

            Predicate<int> eve = isEven;
            bool e = eve(26);
            Console.WriteLine(e);
           
        }
    }


    class CallBack
    {
        public static void display()
        {
            Console.WriteLine("Good Morning");
        }

        public static void square(int a, Action d1)
        {
            Console.WriteLine("Square "+(a*a));
            d1();
        }

        static void Main(string[] args)
        {
            square(10, display);
            square(7, () => Console.WriteLine("Good Afternoon"));
        }
    }
}











//Func delegate - use when funtion compulsary return a value back
                //and can take zero or max 16 parameters

//Action delegate - when funtion takes void return type and 0 or max 16 parametes

//Predicate - if funtion returns compulary boolean value back and may take o or max16 parameters