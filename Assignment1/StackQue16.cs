using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.Assignment1
{
    internal class StackQue16
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);

            Console.WriteLine("Original Stack: ");
            foreach (int i in st)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("After applying Push: ");
            st.Push(99);
            foreach (int i in st)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("After applying Pop 2 times: ");
            st.Pop();
            st.Pop();
            foreach (int i in st)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Peek element: "+st.Peek());


        }
    }

    class Order 
    {
        int orderId;
        string city;
        string itemname;
        string status;

        public Order(int orderId, string city, string itemname, string status)
        {
            this.OrderId = orderId;
            this.City = city;
            this.Itemname = itemname;
            this.Status = status;
        }

        public int OrderId { get => orderId; set => orderId = value; }
        public string City { get => city; set => city = value; }
        public string Itemname { get => itemname; set => itemname = value; }
        public string Status { get => status; set => status = value; }

    }
    class FlipKartQue18
    {
        static void Main(string[] args)
        {
            
            List<Order> orders = new List<Order>();
            orders.Add(new Order(101,"Pune","Laptop","Delivered"));
            orders.Add(new Order(102, "Mumbai", "TV", "Pending"));
            orders.Add(new Order(103, "Pune", "Refrigrator", "Pending"));
            orders.Add(new Order(104,"Panjim","Sofa","Delivered"));
            orders.Add(new Order(105, "Kolhapur", "Washing MAchine", "Pending"));

            Dictionary<string, int> dd = new Dictionary<string, int>();

            foreach(Order od in orders)
            {
                if(od.Status == "Pending")
                {
                    if (dd.ContainsKey(od.City))
                    {
                        int oldval = dd[od.City];
                        dd[od.City] = oldval + 1;
                    }
                    else
                    {
                        dd.Add(od.City, 1);
                    }
                }
                
            }
            foreach(KeyValuePair<string, int> kv in dd)
            {
                Console.WriteLine(kv.Key+"  "+kv.Value);
            }
            
        }
    }

    class Dept
    {
        string deptname;

        public Dept(string deptname)
        {
            this.Deptname = deptname;
        }

        public string Deptname { get => deptname; set => deptname = value; }
    }
    class Employee
    {
        int id;
        string name;
        Dept d;

        public Employee(int id, string name, Dept d)
        {
            this.Id = id;
            this.Name = name;
            this.D = d;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        internal Dept D { get => d; set => d = value; }

        public override string ToString()
        {
            return "ID: " + id + "\tName: " + name + "\tDepartment: " + d.Deptname;
        }

    }

    class LinkedListQue17
    {
        static void Main(string[] args)
        {
            LinkedList<Employee> emp = new LinkedList<Employee>();
            emp.AddFirst(new Employee(10, "Dattaprasad", new Dept("IT")));
            emp.AddLast(new Employee(20, "Shubham", new Dept("Support")));
            emp.AddLast(new Employee(30, "Devesh", new Dept("Support")));
            emp.AddLast(new Employee(35, "Rehan", new Dept("IT")));

            string dname = "";

            foreach(Employee e in emp)
            {
                if(e.Id == 10)
                {
                    dname = e.D.Deptname;
                    break;
                }
            }
            foreach(Employee e in emp)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("************************");
            for(int i=0; i < emp.Count; i++)
            {
                Employee e = emp.ElementAt(i);
                if(e.D.Deptname == dname)
                {
                    emp.Remove(e);
                }
            }
            foreach (Employee e in emp)
            {
                Console.WriteLine(e);
            }
        }
    }


    class SortBySalary : IComparer<Emp>
    {
        public int Compare(Emp? x, Emp? y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }

    class Emp : IComparable<Emp>
    {
        string name;
        int salary;

        public Emp(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            return "Name: " + name + "\tSalary: " + salary;
        }
        public int CompareTo(Emp others)
        {
            return this.salary.CompareTo(others.salary);
        }
    }
    class SortedListQue20
    {
        static void Main(string[] args)
        {
            SortedList<Emp, string> sl = new SortedList<Emp, string>(new SortBySalary());
            sl.Add(new Emp("Datta", 30000), "IT");
            sl.Add(new Emp("Prasad", 25000), "Marketing");
            sl.Add(new Emp("Aish", 25000), "Sales");

            Console.WriteLine("Employee details are: ");
            foreach(KeyValuePair<Emp,string> kv in sl)
            {
                Console.WriteLine(kv.Key+"   "+kv.Value);
            }

           
        }
    }
}
