using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{

    class ReadOnlyExample
    {
        //property fields
        public readonly int initialvalue = 5;
        public static readonly double pi;


        public ReadOnlyExample(int initialvalue)
        {
            initialvalue = initialvalue;
            initialvalue = 20;
        }
        static ReadOnlyExample()
        {
            pi = 3.1585;
        }

        public void PrintValues()
        {
            Console.WriteLine($"initial Values: {initialvalue}");
            Console.WriteLine($"Value of pi:{pi}");
        }
    }
    internal class ReadOnlyEx
    {
        static void Main()
        {
            ReadOnlyExample read = new ReadOnlyExample(10);
            read.PrintValues();
        }
    }
}
