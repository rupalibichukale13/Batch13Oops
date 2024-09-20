using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class BasicsArrayAssign
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Console.Write("Given Array is: ");
            for (int i = 0; i<arr.Length; i++)
            {
                Console.Write(arr[i]+ " ");
            }


            Console.WriteLine();
            //print alternate element in array 
            Console.Write("Alternate Elements in given array is: ");
            for (int i = 0; i <= arr.Length; i += 2)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            //print number of elements of an array
            Console.Write("Number of Elements of given array is: " + arr.Length);

            //find Smallest and largest number in an array
            Console.WriteLine();
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int min = arr[0];
            
            int max = arr[1];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Smallest Number of given array is: " + min);
            Console.WriteLine("Largest Number of given array is: " + max);


        }


    }
            
        }
    

