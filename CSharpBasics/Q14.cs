using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Q14
    {
        public static void Main(String[] args)
        {
            string string1 = Console.ReadLine();
            Console.Write("Enter the first string: "
                              + string1);

            // Get the strings which is to be checked
            string string2 = Console.ReadLine();
            Console.Write("Enter the second string :"
                              + string2);

            // Check if both strings are equal
            Console.WriteLine("\nAre both strings same: ");

            if (string1.Equals(string2) == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
