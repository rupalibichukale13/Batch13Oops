using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class Operators
    {
        public static void Main()
        {
            //Arithmetic Operators
            int a = 10;
            int b = 3;
            //int c = a + b;
          
            Console.WriteLine("Arithmetic Operator");
            Console.WriteLine($"Addition of two numbers is:{a + b}");  //addition a+b=13
            //Console.WriteLine(c);
            Console.WriteLine($"Substraction is:{a - b}");
            Console.WriteLine($"Multiplication is: {a * b}");
            Console.WriteLine($"Division is: {a / b}");
            Console.WriteLine($"Modulus is: {a % b}");


            //Relational Operators
            Console.WriteLine("Relational Operator: a=10 & b=3");

            Console.WriteLine($"a == b:{a == b}");
            Console.WriteLine($"a != b:{a != b}");
            Console.WriteLine($"a > b:{a > b}");
            Console.WriteLine($"a < b:{a < b}");
            Console.WriteLine($"a >= b:{a >= b}");
            Console.WriteLine($"a <= b:{a <= b}");

            //Logical Operator
            bool x = true;
            bool y = false;

            Console.WriteLine("Logical Operator");
            Console.WriteLine($"x && y:{x && y}");
            Console.WriteLine($" x || y: {x || y}");
            Console.WriteLine($"!x:{!x}");




        }
    }
}
