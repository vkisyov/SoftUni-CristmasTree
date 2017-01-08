using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniTesting
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; ++i)
            {
                string str1 = new string('*', i);
                string str2 = new string(' ', i);
                Console.Write(str2);
                Console.Write(str1);
                Console.Write(" | ");
                Console.Write(str1);
                Console.WriteLine();
            }

        }
    }
}
