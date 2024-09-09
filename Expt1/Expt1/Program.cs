using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 4;
            Console.WriteLine("Addition of Two Numbers is {0}", a + b);
            Console.WriteLine("Substraction of Two Numbers is {0}", a - b);
            Console.WriteLine("Multiplication of Two Numbers is {0}", a * b);
            Console.WriteLine("Division of Two Numbers is {0}", (float)a / b);
            Console.Read();
        }
    }
}
