using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.July26
{
    class Book
    {
        int price;
        string name;

        public Book(int price, string name)
        {
            this.Price = price;
            this.Name = name;
        }

        public int Price { get => price; set => price = value; }
        public string Name { get => name; set => name = value; }

        public override bool Equals(object? obj)
        {
            return obj is Book book &&
                   price == book.price &&
                   name == book.name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(price, name);
        }

        public override string ToString()
        {
            return "Name: " + name + "\tPrice: " + price;
        }


    }

    internal class HashSetDemo
    {
        static void Main(string[] args)
        {
            HashSet<string> hs = new HashSet<string>(); 
            hs.Add("Datta");
            hs.Add("Datt");
            hs.Add("Prasad");
            hs.Add("Datt");

            foreach (string s in hs)
            {
                Console.WriteLine(s);
            }


            HashSet<Book> hs2 = new HashSet<Book>();
            hs2.Add(new Book(250, "The Secret"));
            hs2.Add(new Book(500, "Harry Potter"));
            hs2.Add(new Book(200, "The Secret"));

            foreach (Book b in hs2)
            {
                Console.WriteLine(b);
            }
           
        }
    }

    class HashSetDemo2
    {
        static void Main(string[] args)
        {
            HashSet<int> h1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
            HashSet<int> h2 = new HashSet<int>() { 3, 4, 5, 6, 7, 8 };

            Console.WriteLine("First: "+String.Join("  ",h1));
            Console.WriteLine("Second: " + String.Join("  ", h2));

            h1.IntersectWith(h2);
            Console.WriteLine("After intersect with second: " + String.Join("  ", h1));
            
            h2.UnionWith(h1);
            Console.WriteLine("After union with First: " + String.Join("  ", h2));

            Console.WriteLine(h1.IsSupersetOf(h2));

        }
    }
}
