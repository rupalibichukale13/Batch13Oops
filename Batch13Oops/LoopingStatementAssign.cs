using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class LoopingStatementAssign
    {
        static void Main()
        {
            Console.WriteLine("Food Items");
            Console.WriteLine("1:Burger:300 \n2:Pizza:200 \n3:Salad:100  \n4:Momos:250");
            Console.WriteLine("Enter Your Choice");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Burger = 300 ");
                    break;

                case 2:
                    Console.WriteLine("Pizza = 200 ");
                    break;

                case 3:
                    Console.WriteLine("Salad = 100 ");
                    break;

                case 4:
                    Console.WriteLine("Momos = 250 ");

                    break;

                    default:
                    Console.WriteLine("Food Items are Not Available");
                    break;

            }

            
        }
    }
}
