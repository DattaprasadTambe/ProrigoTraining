using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.July26
{
    internal class SortedSet
    {
        static void Main(string[] args)
        {
            SortedSet<string> ss = new SortedSet<string>() { "Datta", "Aish", "Shubham", "Rehan","Devesh"}; 
            foreach (string s in ss)
            {
                Console.WriteLine(s);
            }
        }
    }
}
