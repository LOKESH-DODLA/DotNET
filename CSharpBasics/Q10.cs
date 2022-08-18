using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Q10
    {
        static void Main(string[] args)
        {
            for(int i = 100; i <= 200; i++)
            {
                if(i % 7 == 0)
                    Console.WriteLine(i);   
            }
        }
        
    }
}
