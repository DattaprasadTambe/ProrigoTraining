using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.Assignment1
{
    internal class DictionaryQue11
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dd = new Dictionary<int, string>();
            dd.Add(1, "Elon Musk");
            dd.Add(2, "Ratan Tata");
            dd.Add(3, "Bill Gates");
            dd.Add(4, "Jeff Bezos");

            Console.WriteLine("Elements in dectionary are: ");
            foreach (KeyValuePair<int, string> kv in dd)
            {
                Console.WriteLine(kv.Key + "   " + kv.Value);
            }

           
        }
    }

    class DictionaryQue12
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dd = new Dictionary<int, string>();
            dd.Add(21, "Datta");
            dd.Add(22, "Prasad");
            dd.Add(23, "Subhash");
            dd.Add(24, "Tambe");
            Console.WriteLine("Elements in dectionary are: ");
            foreach (KeyValuePair<int, string> kv in dd)
            {
                Console.WriteLine(kv.Key + "   " + kv.Value);
            }

            Console.WriteLine("Displaying only the keys from the dictionary: ");
            List<int> k = dd.Keys.ToList();
            foreach (int i in k)
            {
                Console.WriteLine(i);
            }
               
           
        }
    }

    class DictionaryQue13
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dd = new Dictionary<int, string>();
            dd.Add(21, "Datta");
            dd.Add(22, "Prasad");
            dd.Add(23, "Subhash");
            dd.Add(24, "Tambe");
            Console.WriteLine("Elements in dectionary are: ");
            foreach (KeyValuePair<int, string> kv in dd)
            {
                Console.WriteLine(kv.Key + "   " + kv.Value);
            }

            Console.WriteLine("Displaying only the Values from the dictionary: ");
            List<string> k = dd.Values.ToList();
            foreach (string i in k)
            {
                Console.WriteLine(i);
            }
                

        }
    }

    class QueueQue15
    {
        static void Main(string[] args)
        {
            Queue<string> que = new Queue<string>();
            que.Enqueue("Datta");
            que.Enqueue("Prasad");
            que.Enqueue("Rehan");
            que.Enqueue("Devesh");
            que.Enqueue("Shraddha");
            Console.WriteLine("Original Queue: ");
            foreach(string i in que)
            {
                Console.WriteLine(i);
            }
            que.Dequeue();
            que.Dequeue();

            Console.WriteLine("Queue after removing first 2 elements: ");
            foreach (string i in que)
            {
                Console.WriteLine(i);
            }
        }
    }

    class DictCustClass
    {
        int id;

        public DictCustClass(int id)
        {
            this.Id = id;
        }

        public override string ToString()
        {
            return "Id: " + id;
        }

        public int Id { get => id; set => id = value; }
    }
    class DictionaryQue14
    {
        static void Main(string[] args)
        {
            Dictionary<DictCustClass, string> dd = new Dictionary<DictCustClass, string>();
            dd.Add(new DictCustClass(21), "Dattaprasad");
            dd.Add(new DictCustClass(22), "Reshma");
            dd.Add(new DictCustClass(23), "Shraddha");

            Console.WriteLine("Elements in dictionary are: ");
            foreach(KeyValuePair<DictCustClass, string> kv in dd)
            {
                Console.WriteLine(kv.Key+"   "+kv.Value);
            }
        }
    }
}
