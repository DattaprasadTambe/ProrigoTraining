using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.July22
{
    internal class DictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dd = new Dictionary<int, string>();
            dd.Add(1, "Datta");
            dd.Add(2, "Prasad");
            dd.Add(3,"Subhash");
            dd.Add(4, "Tambe");

            dd[3] = "DP";

            dd.Remove(4);

            Console.WriteLine("Count of dictionary: "+dd.Count);

            Console.WriteLine(dd.ContainsKey(5));
            Console.WriteLine(dd.ContainsValue("DP"));

            List<int> k = dd.Keys.ToList();

           Console.WriteLine(dd[3]);

            foreach(KeyValuePair<int, string> kv in dd)
            {
                Console.WriteLine(kv.Key+"   "+kv.Value);
            }
        }
    }

   
}
