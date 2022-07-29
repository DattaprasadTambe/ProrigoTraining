using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.July22
{
   
    class LinkedListDemo
    {
        static void Main(string[] args)
        {
            LinkedList<int> l1= new LinkedList<int>();
            l1.AddLast(1000);
            l1.AddLast(2000);
            l1.AddFirst(3000);
        }
    }

    internal class LinkedListDemo1
    {
        public static void AddLinkedList(LinkedList<int> ll)
        {
            Console.WriteLine("Enter elements: ");
            ll.AddLast(int.Parse(Console.ReadLine()));
            ll.AddLast(int.Parse(Console.ReadLine()));
            ll.AddFirst(int.Parse(Console.ReadLine()));

            Console.WriteLine("Add element after: ");
            ll.AddAfter(ll.Find(int.Parse(Console.ReadLine())), int.Parse(Console.ReadLine()));

            Console.WriteLine("Add element before: ");
            ll.AddBefore(ll.Find(int.Parse(Console.ReadLine())), int.Parse(Console.ReadLine()));
            foreach (int i in ll)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            AddLinkedList(ll);

            
        }
    }
}
