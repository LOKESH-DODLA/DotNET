using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Q4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Number : ");
            int number = int.Parse(Console.ReadLine());

            if ((number & 1) == 0)
                Console.WriteLine("Given Number is Even : " + number);
            else if ((number & 1) == 1)
                Console.WriteLine("Given Number is Odd : " + number);
        }
    }
}
