using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.July25
{
    internal class SortedListDemo
    {
        static void Main(string[] args)
        {
            SortedList<string, int> ss = new SortedList<string, int>();
            ss.Add("Rehan", 29);
            ss.Add("Devesh", 26);
            ss.Add("Shraddha", 3);
            ss.Add("Datta", 21);
            ss.Add("Mayur", 15);

            ss.RemoveAt(0);

            foreach (var i in ss)
            {
                Console.WriteLine(i.Key+" : "+i.Value);
            }

            ss.Remove("Devesh");
            ss["Shraddha"] = 30;
            Console.WriteLine("****************************");

            foreach (var i in ss)
            {
                Console.WriteLine(i.Key + " : " + i.Value);
            }

            Console.WriteLine(ss.ContainsKey("AA"));
            Console.WriteLine(ss.Count);
        }
    }

    class SBSot : IComparer<StringBuilder>
    {
        public int Compare(StringBuilder x,StringBuilder y)
        {
            return y.ToString().CompareTo(x.ToString());
        }
    }

    class SortedListDemo2
    {
        static void Main(string[] args)
        {
            SortedList<StringBuilder, int> sb = new SortedList<StringBuilder, int>(new SBSot());
            sb.Add(new StringBuilder("Amit"), 90);
            sb.Add(new StringBuilder("Amita"), 90);
            sb.Add(new StringBuilder("Rehan"), 85);
            sb.Add(new StringBuilder("Datta"), 88);

            foreach (var i in sb)
            {
                Console.WriteLine(i.Key+"  :  "+i.Value);
            }
           
        }
    }
}
