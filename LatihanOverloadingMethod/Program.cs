using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers num = new Numbers();

            Console.WriteLine("Minimum #1: {0}", num.FindMinimum(3, 1));
            Console.WriteLine("Minimum #2: {0}", num.FindMinimum(3, 2, 4));
            Console.WriteLine();
            Console.WriteLine("Maximum #1: {0}", num.FindMaximum(3, 1));
            Console.WriteLine("Maximum #2: {0}", num.FindMaximum(3, 2, 4));

            Console.ReadKey();
        }
    }
}
