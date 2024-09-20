using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class ForEachLoopAssign
    {
        static void Main()
        {
            string[] mobiles = { "Vivo", "Apple", "OnePlus", "Samsung", "OPPO", "Realme", "Xiaomi", "Nokia", "Lenovo", "Poco" };
            foreach (string mobile in mobiles)
            {
                Console.WriteLine("The Mobile Brand is:" + mobile);
            }
        }
    }
}
       
            

