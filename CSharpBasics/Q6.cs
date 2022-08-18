using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Q6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of terms : ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(i * i);
            }
        }
        
    }
}

