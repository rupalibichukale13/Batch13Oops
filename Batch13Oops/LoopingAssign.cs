using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class LoopingAssign
    {
        static void Main()
        {
            Console.WriteLine("========= for loop ==========");

            for (int  n = 1; n<=10; n++)
            {
                Console.WriteLine("Student No.:" + n);
            }

            Console.WriteLine("========= while loop ==========");

            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("Student No.:" +i);
                i++;

            }

            Console.WriteLine("========= Do while loop ==========");
            int j = 1;
            do
            {
                Console.WriteLine("Student No.:" + j);
                j++;
            }
            while (j <= 10);
                

            }
        }
    }

