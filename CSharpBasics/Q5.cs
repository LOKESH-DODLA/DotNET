using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Q5
    {
        static void Main(string[] args)
        {
            double celsius;
            Console.WriteLine("Enter your Temperature");
            double fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine("Fahrenheit: " + fahrenheit);
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celsius: " + celsius);
        }
    }
}
