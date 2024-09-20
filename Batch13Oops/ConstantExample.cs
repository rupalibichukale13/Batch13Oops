using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{

    class Constantex
    {

        //normal variable declaration
        public int a = 10;
        public const double pi = 3.15485;
        public const string AppName = "MyApp";
        public string name = "Test";

        public void PrintConstants()
        {
            Console.WriteLine(name);
            Console.WriteLine($"The value of pi is:{pi}");
            Console.WriteLine($"Application Name: {AppName}");

            name = "Test1";
            Console.WriteLine(name);
        }
    }
        internal class ConstantExample
        {
            static void Main()
            {
                Constantex cons = new Constantex();
                cons.PrintConstants();
            }
        }
    }

