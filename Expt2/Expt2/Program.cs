using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, sum = 0;
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(i);
                sum = sum + i;
            }
            Console.WriteLine("The Sum of first 10 Natural Numbers is {0}",sum);
            Console.Read();
        }
    }
}
