using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class StringBuilderAssign
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Welcome ");
            sb.Append("To ");
            sb.Append("CodeMind ");
            sb.Append("Technology ");
            sb.Append("Pune");

            string result1 = sb.ToString();
            Console.WriteLine("-----Original String is------");
             Console.WriteLine(result1);

            Console.WriteLine("------Replacement of Specific Substring is------");
            sb.Replace("Technology", "Office");
            string result = sb.ToString();
            Console.WriteLine(result.ToString());

            Console.WriteLine("-----Remove The Specific Subtring-------");
            sb.Remove(0, 3);
            Console.WriteLine(sb.ToString());

        }
    }
}
