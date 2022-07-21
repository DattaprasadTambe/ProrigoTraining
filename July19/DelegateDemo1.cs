using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.July19
{
    public delegate void Sum(int a, int b);
    public delegate void Subtract(int a, int b);
    internal class DelegateDemo1

    { 
        //Declare a delegate
        public delegate void mySquare(int x);
        public static void Square(int x)
        {
            Console.WriteLine("Square of "+x+" : "+(x*x));
        }
        
        public void Cube(int x)
        {
            Console.WriteLine("Cube of "+x+" : "+(x*x*x));
        }

        public static void doubleUp(int a)
        {
            Console.WriteLine("Double up : "+(2*a));
        }

        public delegate void Mul(int a, int b);
        public static void Multiply(int a, int b)
        {
            Console.WriteLine("Multiplication : "+(a*b));
        }

        //Sum s = delegate (int a, int b)  // Sum s = (a,b) =>  *Labmda expression*
        public static Sum s = (a, b) =>
        {
            Console.WriteLine("Sum : " + (a + b));
        };

        //no is prime or not
        
        static void Main(string[] args)
        {
            DelegateDemo1 dd = new DelegateDemo1();
            //set a target
            mySquare sq = Square;
            sq = sq + dd.Cube;
            sq = sq + doubleUp;
            //invoke
            sq(7);

            Mul m = Multiply;
            m(5, 5);

            //calling a delegate
            s(5, 10);



        }
    }
}
