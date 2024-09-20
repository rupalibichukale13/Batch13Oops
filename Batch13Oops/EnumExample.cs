using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    
    public enum Days
        {
           Sunday,
           Monday, 
           Tuesday,
           Wednesday,
           Thursday,
           Friday,
           Satrurday
        }

    enum HTTPStatusCode
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbideen = 500,
        NotFound = 400

    }
    internal class EnumExample
    { 
        static void Main()
        {
            Days today = Days.Sunday;

            //Week days

            switch (today)
            {
                case Days.Sunday:
                    Console.WriteLine("Today is Sunday");
                    break;

                case Days.Monday:
                    Console.WriteLine("Today is Monday");
                    break;


                case Days.Tuesday:
                    Console.WriteLine("Today is Tuesday");
                    break;

                case Days.Wednesday:
                    Console.WriteLine("Today is Wednesday");
                    break;

                case Days.Thursday:
                    Console.WriteLine("Today is Thursday");
                    break;

                case Days.Friday:
                    Console.WriteLine("Today is Friday");
                    break;

                case Days.Satrurday:
                    Console.WriteLine("Today is Saturday");
                    break;


            }

            //To check week end
            //Console.BackgroundColor = ConsoleColor.Cyan;
            if (today == Days.Satrurday || today == Days.Sunday)
            {
                Console.WriteLine("Its weekend");

            }
            else
            {
                Console.WriteLine("it's weekdays");
            }

            //Console.BackgroundColor = ConsoleColor.Magenta;

            HTTPStatusCode code = HTTPStatusCode.OK;
            Console.WriteLine("HTTP Status Code:" + code);

            int codenumber = (int)code;
            Console.WriteLine("HTTP status code numbr:" + codenumber);


        }
    

    }
}
