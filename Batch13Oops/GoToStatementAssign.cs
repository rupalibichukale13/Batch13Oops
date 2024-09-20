using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class GoToStatementAssign
    {
       static void Main()
        {
        start:
            Console.WriteLine("Enter a Age Between 1 to 120 :");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age >=1 && age <= 120)
            {
                Console.WriteLine("Age is:" + age);
            }
            else
            {
                Console.WriteLine("Enter a Valid Age");
                goto start;
            }
        }
    }
}

