using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.July20
{
    //Non generic
    class K
    {
        private object ob;
        public object Ob { get => ob; set => ob = value; }
    }

    //Generic
    class KK<T>
    {
        private T ob;
        public T Ob { get => ob; set => ob = value; }
    }
    internal class CollectionDemo1
    {
        static void Main(string[] args)
        {
            KK<string> obj = new KK<string>();
            obj.Ob = "Datta";
            string s = obj.Ob;
            Console.WriteLine(s);


            K k = new K();
            k.Ob = 21;
            k.Ob = "DP";
            
            int i = (int)k.Ob;
            string str = (string)k.Ob;
           
            
        }
        
    }
}







//Non generic - Can store heterogenous (mix) data
//generic - same/ homogenous data
//egs- list, LinkedList, Stack, Queue, Dictionary, SortedList,SoretedSet, HashSet

//int x=10;
//object ob = x;
//value of x will be store in stack
// and when assignin a x to ob the value 10 will be store in heap and its reference will be return to ob in stack
//Autoboxing - automatically converting primitive to respective objvt ie. value type to reference type

//int y = (int)ob;
//unboxing - conveting object to primitive

//Homework
//ref out keywords
//param[] array
//const and readonly