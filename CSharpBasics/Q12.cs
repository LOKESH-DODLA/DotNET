using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Q12
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter your Size : ");
            int size = int.Parse(Console.ReadLine());
            int[] marks = new int[size]; 

            Console.WriteLine("Enter your marks : ");

            for(int i = 0; i < size; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }

            /*Console.WriteLine("To Print");
            foreach(int mark in marks)
                Console.Write(mark + " ");*/

            // Sum(marks);
            // Console.WriteLine("Sum is : " + Sum(marks));

            // Average(marks);

            MaxAndMin(marks);   


        }

        public static int Sum(int[] array)
        {
            int sum = 0;

            for(int i = 0; i < array.Length; i++)
                sum += array[i];
            //Console.WriteLine(sum);
            return sum;
        }

        public static void Average(int[] array)
        {
            int length = array.Length;
            double average = Sum(array) / length;
            Console.WriteLine("Average of Marks : " + average); 
        }

        public static void MaxAndMin(int[] array)
        {
            int max = array[0];
            int min = array[0];

            for(int i = 1; i < array.Length; i++)
            {
                if(array[i] > max)
                    max = array[i];
                else if(array[i] < min)
                    min = array[i];
            }

            Console.WriteLine("Maximum marks is : " + max);
            Console.WriteLine("Minimum marks is : " + min);

        }


    }
}
