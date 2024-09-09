using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Dog
    {
        public virtual void eat()
        {
            Console.WriteLine("Dog is Eating");
        }
    }
    public class Cat:Dog
    {
        public override void eat()
        {
            Console.WriteLine("Cat is Eating");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.eat();
            Console.ReadLine();
        }
    }
}
