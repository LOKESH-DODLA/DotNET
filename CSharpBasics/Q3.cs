using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Numbers : ");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            while (firstNumber <= secondNumber)
            {
                Console.WriteLine("\n" + firstNumber);
                firstNumber++;
            }
        }
    }
}
