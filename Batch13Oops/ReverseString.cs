using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class ReverseString
    {
        static void Main()
        {
            String s = "CODEMIND TECHNOLOGY";
            String reverse = Reverse(s);

            Console.WriteLine("Original String is:"  + s);
            Console.WriteLine("Reversed String is:"  + reverse);


            static string Reverse(string str)
            {
                string  reverseString = "";

                for (int i = str.Length-1; i>=0; i--)
                {
                    reverseString += str[i];

                }
                return reverseString;
            }

        }
    }
}
