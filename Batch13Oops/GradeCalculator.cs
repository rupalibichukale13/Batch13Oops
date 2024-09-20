using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class GradeCalculator
    {
        static void Main()
        {
            Console.WriteLine("Enter a Marks:");
            int number = int.Parse(Console.ReadLine());
            if (number > 100)
            {
                Console.WriteLine("Enter a Grade Between 0-100");
            }
           
            else if (number >= 99)
                
            {
                Console.WriteLine("Enter a Grade A");

            }
            else if (number >= 80)
            {
                Console.WriteLine("Enter a Grade B");
            }
            else if (number>= 75)
            {
                Console.WriteLine("Enter a Grade C");
            }
            else if(number >= 60)
            {
                Console.WriteLine("Enter a Grade D");
            }
            else
            {
                Console.WriteLine("Enter a Grade F");
            }
            Console.ReadLine();
        }
    }
}
