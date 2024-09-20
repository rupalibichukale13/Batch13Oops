using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class ContinueStatementAssign
    {
        static void Main()
        {
            int x = 1;
            for ( x = 1; x <=20; x++)
            {
                if (x % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine(" Prints 1 to 20 numbers Except those that are divisible by 3 : " +x);
            }
        }
    }
}
