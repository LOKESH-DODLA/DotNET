using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Q9
    {
        public static void Main()
        {
            int j, n;

            Console.Write("Input the number (Table to be calculated) : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (j = 1; j <= 20; j++)
            {
                Console.Write("{0} X {1} = {2} \n", n, j, n * j);
            }
        }
    }
}
