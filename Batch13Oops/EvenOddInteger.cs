using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class EvenOddInteger
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Console.Write("Given Array is:" );
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ " ");
            }
            Console.Write("\nEven Numbers from Given Array is:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
                Console.Write("\nOdd Numbers from Given Array is:");
                for (int i= 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
                Console.WriteLine("\n\n\n");
                }

        }
    }

