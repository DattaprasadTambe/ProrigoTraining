using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.July21
{
    internal class ParamsArrayDemo1
    {

        public static int ParamArray(params int[] arr)
        {
            int sum = 0;

            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int sum = ParamArray(1,2,3,4,5,6,7,8,9,10);
            Console.WriteLine(sum);
        }
    }
}
