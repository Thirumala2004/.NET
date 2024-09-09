using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student(5, "Ravi");
            student s2 = new student("Ravi", 10);
            Console.WriteLine("First Constructor");
            s1.show();
            Console.WriteLine("Second Constructor");
            s2.show();
            Console.ReadLine();
        }
    }

    public class student
    {
        public int id;
        public string name;
        public student(int x, string s)
        {
            id = x;
            name = s;
        }
        public student(string s, int x)
        {
            name = s;
            id = x;
        }
        public void show()
        {
            Console.WriteLine("Roll No : " + id);
            Console.WriteLine("Name : " + name);
        }
    }
}
