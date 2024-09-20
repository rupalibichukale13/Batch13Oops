using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class Array
    {
        static void Main()
        {
            ////Declare Array
            //string[] Mobile = new string[4];

            ////Assiging values
            //Mobile[0] = "Apple";
            //Mobile[1] = "Samsung";
            //Mobile[2] = "Vivo";
            //Mobile[3] = "OnePlus";

            ////Access arrays value

            //Console.WriteLine("Mobile in array index:");

            //for (int i = 0; i < Mobile.Length; i++)
            //{
            //    Console.WriteLine(Mobile[i]);
            //}

            //// reverse number

            //int[] Numbers = { 1, 2, 3, 4, 5 };

            //// print original array
            //Print(Numbers);

            ////Reverse Number
            //Reverse(Numbers);
            //Console.WriteLine("Print Reverse array");
            //Print(Numbers);


            //initialize multidimensional array 

            int[,] matrix = new int[,]
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7,8,9 }
            };

            //accessing the elements from array

            Console.WriteLine("Element at (0 , 0):"+ matrix[0, 0]);
            Console.WriteLine("Element at (1, 2):" +matrix[1, 2]);


            //print all elements in array

            for(int i = 0; i<3; i++)
            {
                for (int j = 0; j<3; j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                
                Console.WriteLine();
                }
            //jagged array
            //declaration of the jagged array
            int[][] jaggedArray = new int[][]
            {
                new int []{1,2},
                 new int []{3,4,5},
                  new int []{6,7,8,9},

            };
            //Accessing elements in jagged array
            Console.WriteLine("Element at [0][1]:" + jaggedArray[0][1]);
            Console.WriteLine("Element at [2][3]:" + jaggedArray[2][3]);

            //looging through a jagged array
            for(int i = 0; i<jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "  ");

                }
                Console.WriteLine();
            }


            //String
            string str = "Hello World";
            Console.WriteLine(str);
            str = "Test";
            Console.WriteLine(str);

            string firstName = "Rupali ";
            string lastName = "Bichukale";

            string name = firstName + lastName;
            Console.WriteLine(name);
            

            //string builder
            //creating a object for string builder
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(" ,");
            sb.Append("World");

           // sb.Remove(2, 5);




           // string result = sb.ToString();

           // Console.WriteLine(result);

            //to add the value in specific index
            sb.Insert(5, " there ");


            //replace a string 
            sb.Replace("World", "C# Developer");
            string result = sb.ToString();
            Console.WriteLine(result.ToString());

            sb.Clear();

            //Boxing 

            int num = 30; //value type(int)
            object obj = num; //boxing it will convert value to object(reference)

            //UnBoxing 

            object objnew = 35; //boxed integer value
            int num1 = (int) objnew;



        }
        public static void Print(int[] arr)

        {
            foreach (var num in arr)
            {
                Console.WriteLine(num + "");
            }
        }


        public static void Reverse(int[] arr)
            
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                //element swaping
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}
