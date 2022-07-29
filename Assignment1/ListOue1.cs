using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.Assignment1
{
    internal class ListOue1
    {
        static void Main(string[] args)
        {
            List<int> ls1 = new List<int>();
            ls1.Add(1);
            ls1.Add(2);
            ls1.Add(3);
            ls1.Add(4);
            ls1.Add(5);

            List<string> ls2 = new List<string>();
            ls2.Add("Hii");
            ls2.Add("Good");
            ls2.Add("Morning");
            ls2.Add("Have a");
            ls2.Add("Nice Day");

            Console.WriteLine("List 1 with Integers: ");
            foreach (int i in ls1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("List 2 with strings: ");
            foreach (string i in ls2)
            {
                Console.WriteLine(i);
            }

            
        }
    }

    class ListOue2
    {
        static void Main(string[] args)
        {
            List<Tuple<int, string>> lst = new List<Tuple<int, string>>();
            lst.Add(new Tuple<int, string>(1, "Dattaprasad"));
           
            

            foreach(var i in lst)
            {
                Console.WriteLine(i.Item1);
                Console.WriteLine(i.Item2);
            }
        }
    }

    class ListOue3
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Green");
            colors.Add("Black");
            colors.Add("Purple");

            foreach(string i in colors)
            {
                Console.WriteLine(i);
            }
        }
    }

    public class Swap2EleQue4
    {
        public static List<int> swap(List<int> l, int i, int j)
        {
            //List<int> l = ls;
            int temp = l[i];
            l[i] = l[j];
            l[j] = temp;

            return l;
        }

        public static void Main()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

            List<int> ls = swap(nums, nums[1], nums[0]);
            foreach(int i in ls)
            {
                Console.WriteLine(i);
            }
            //nums.Swap(2, 3);
            //Console.WriteLine(String.Join(", ", nums)); 
        }
    }

    class InsertinListQue5
    {
        static void Main(string[] args)
        {
            List<int> ls = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Elements in list are: ");
            foreach (int i in ls)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Enter a number to remove");
            int a = int.Parse(Console.ReadLine());
            int c = ls.IndexOf(a);
            ls.Remove(a);
            Console.WriteLine("Enter a number to that postion");
            int b = int.Parse(Console.ReadLine());
            ls.Insert(c, b);
           
            Console.WriteLine("New list elements are: ");
            foreach (int i in ls)
            {
                Console.WriteLine(i);
            }
        }
    }
}
