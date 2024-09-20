using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class SumOfArray
    {
        static void Main()
        {
           //Sum values of an array
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int sum = 0;
            Console.Write("The Given Array is: "); 
            foreach (int i in arr)
            {
                Console.Write(i + "  ");
                sum += i;
            }
            Console.WriteLine("\nSum of the given Array is: " + sum);

            //calculating the average of an array

            int avg = sum / arr.Length;
            Console.WriteLine("The Average Values of an array is : " + avg);
        }
    }
}
