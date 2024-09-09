using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        static void printInfo(int id,string name)
        {
            Console.WriteLine("Roll No : " + id);
            Console.WriteLine("Name : " + name);
        }
        static void printInfo(string name,int id)
        {
            Console.WriteLine($"Roll No : {id}");
            Console.WriteLine($"Name : {name}");
        }
        static void printInfo(string name)
        {
            Console.WriteLine($"Name : {name}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("First Method:");
            printInfo(518, "Thirumala Naidu");
            Console.WriteLine("Second Method:");
            printInfo("Thiurmala Naidu", 238);
            Console.WriteLine("Third Method:");
            printInfo("Thirumala Naidu");
            Console.ReadLine();
        }
    }
}
