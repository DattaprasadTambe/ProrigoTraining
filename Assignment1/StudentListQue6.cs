using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTraining.Assignment1
{

    class Student
    {
        int id;
        string name;
        double percentage;

        public Student(int id, string name, double percentage)
        {
            this.Id = id;
            this.Name = name;
            this.percentage = percentage;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Percentage { get => percentage; set => percentage = value; }

        public override string ToString()
        {
            return "ID: " + id + "\t Name: " + name + "\tPercentage: " + percentage;
        }
    }
    class StudentListQue6
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(21, "Dattaprasad", 92.69));
            students.Add(new Student(22, "Shubham", 88.45));
            students.Add(new Student(23, "Rehan", 84.34));

            Console.WriteLine("List of Student: ");
            foreach (Student s in students)
            {
                Console.WriteLine(s);
            }
        }
    }

    class ConvertArrayToListQue7
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 21, 34, 56, 87, 98, 34, 69 };

            Console.WriteLine("Array elements are: "+String.Join(" ",arr));

            Console.WriteLine("Converting array to List: ");
            List<int> la = arr.ToList<int>();

            Console.WriteLine("List is: "+String.Join("  ",la));
        }
    }

    class ReverseListQue8
    {
        public static List<string> reverse(List<string> ls)
        {
            int j = ls.Count - 1;
            for(int i=0; i<j; i++)
            {
                string temp = ls[i];
                ls[i] = ls[j];
                ls[j] = temp;
                j--;
            }
            return ls;
        }
        static void Main(string[] args)
        {
            List<string> ls8 = new List<string> { "A", "B", "C", "D", "E" };
            Console.WriteLine("List elements are: "+String.Join("  ",ls8));
            //by creating a method 
            List<string> revls = reverse(ls8);
            Console.WriteLine("After Revering list elements: "+ String.Join("  ", revls));
            Console.WriteLine();

            //using inbuild function
            List<int> intls = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("List elements are: "+String.Join("  ",intls));
            intls.Reverse();
            Console.WriteLine("Reversed List is: "+String.Join("  ",intls));

        }
    }

    class SortStringListQue9
    {
        static void Main(string[] args)
        {
            List<string> slist = new List<string>();
            slist.Add("Rehan");
            slist.Add("Ninad");
            slist.Add("Shraddha");
            slist.Add("Dattaprasad");
            Console.WriteLine("List before sorting: "+String.Join("  ",slist));

            slist.Sort();
            Console.WriteLine("List after sorting: ");
            slist.ForEach(s => Console.WriteLine(s));
        }
    }

    class EmployeeDetails: IComparable<EmployeeDetails>
    {
        string name;
        string designation;
        int age;

        public EmployeeDetails(string name, string designation, int age)
        {
            this.Name = name;
            this.Designation = designation;
            this.Age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Age { get => age; set => age = value; }

        public override string ToString()
        {
            return "Name: " + name + "\tDesignation: " + designation + "\tAge: " + age;
        }

        public int CompareTo(EmployeeDetails other)
        {
            return other.age.CompareTo(this.age);
        }
    }

    class EmployeeListQue10
    {
        static void Main(string[] args)
        {
            List<EmployeeDetails> emp = new List<EmployeeDetails>();
            emp.Add(new EmployeeDetails("Dattaprasad", "Software Developer", 25));
            emp.Add(new EmployeeDetails("Rehan", "Mechanic", 24));
            emp.Add(new EmployeeDetails("Shubham", "HR", 28));
            emp.Add(new EmployeeDetails("Ninad", "Trainee", 22));

            Console.WriteLine("List of Employee: ");
            foreach (EmployeeDetails e in emp)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("\t\t\t");
            emp.Sort();
            Console.WriteLine("After sorting age with descemding order: ");
            foreach (EmployeeDetails e in emp)
            {
                Console.WriteLine(e);
            }


        }
    }
}
