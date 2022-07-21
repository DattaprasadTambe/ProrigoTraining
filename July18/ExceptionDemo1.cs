using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.July18
{
    internal class ExceptionDemo1
    {
        static void Main(string[] args)
        {

            try
            {

                Console.WriteLine("Enter 2 nums :");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Division = " + (n1 / n2));
                Console.WriteLine("Try ends");
                try
                {

                    Console.WriteLine("Enter Name: ");
                    string nm = Console.ReadLine();
                    Console.WriteLine(nm[4]);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);

                }


            }
            catch (FormatException e)
            {
                // Console.WriteLine("In catch 1");
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("In catch 2");
                Console.WriteLine(e.Message);
            }
            catch (SystemException e)
            {
                Console.WriteLine("In catch 3");
                Console.WriteLine(e.Message);
            }
        }
    }
}
