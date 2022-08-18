using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Q11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Numbers : ");
            int firstNumber = int.Parse(Console.ReadLine());
            int SecondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            FindMaximum(firstNumber, SecondNumber, thirdNumber);
            FindMinimum(firstNumber, SecondNumber, thirdNumber);
        }
        public static void FindMaximum(int a, int b, int c)
        {
            int max = 0;
            //		int min = 0;

            while (a > 0 || b > 0 || c > 0)   // || (or Operator) is used for Maximum number
            {
                a--;
                b--;
                c--;
                max++;
            }
            Console.WriteLine("The Maximum value is : " + max);
        }

        public static void FindMinimum(int a, int b, int c)
        {
            
            int min = 0;

            while (a > 0 && b > 0 && c > 0)   // && (and Operator) is used for Minimum number
            {
                a--;
                b--;
                c--;
                min++;
            }
            Console.WriteLine("The Minimum value is : " + min);
        }
    }
}
