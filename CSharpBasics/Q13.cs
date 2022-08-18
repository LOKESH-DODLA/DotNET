using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Q13
    {
        public static void Main(string[] args)
        {
            string word = Console.ReadLine();
            // Console.WriteLine(word.Length);
            // WordReverse(word);

           
        }

        public static void WordReverse(string str)
        {
            int temp;
            string s = Console.ReadLine();
            string[] a = s.Split(' ');
            int k = a.Length - 1;
            temp = k;
            for (int i = k; temp >= 0; k--)
            {
                Console.Write(a[temp] + "" + ' ');
                --temp;
            }
        }

        
    }
}
