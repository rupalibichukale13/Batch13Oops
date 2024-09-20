using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class BreakStatementAssign
    {
        static void Main()
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a Number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                if (num1 < 0)
                {
                    break;
                }
                sum += num1;

            }
            Console.WriteLine("Sum of all user to entered numbers is :" + sum);
        }
    }
}
