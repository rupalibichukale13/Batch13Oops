using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class controlStatement
    {
        static void Main()
        {


            // if statement
            int number = 0;
            if (number == 0) ;
            {
                Console.WriteLine("The Number is positive");
                //if else statement

                if (number > 0)
                {
                    Console.WriteLine("The number is Positive");
                }
                else
                {
                    Console.WriteLine("The Number is Negative");
                }
                // if else if statement

                if (number > 0)
                {
                    Console.WriteLine("The Number is positive");
                }
                else if(number < 0)
                {
                    Console.WriteLine("The Number is Negative");
                }
                else
                {
                    Console.WriteLine("The Number is Zero");
                }
                //Switch Statement

                int Day = 3;
                switch (Day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    default:
                        Console.WriteLine("other day");
                        break;
                }
                //Looping  Statement
                for(int n = 0; n<5; n++)
                {
                    Console.WriteLine("Iteration" + n);
                }
                //While Loop
                int i = 0;
                while (i < 5)
                {
                    Console.WriteLine("Iteration on while loop" + i);
                    i++;
                }

                // do while -- Exit control loop
                int j = 0;
                do
                {
                    Console.WriteLine("Iteration on do while loop:" + j);
                    j++;
                } while (j < 5);


            }

            //for  each
            string[] fruits = { "Apple", "Banana", "Mango", "Kivi", "Grapes", "Jackfruit", "Strawberry", "Watermelon", "Pineapple" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine("The fruit Name is:" + fruit);
            }
            //continue Statement
            for ( int i =0; i<5; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine("Iterations:" + i);
            }
            // go to statement
            int count = 0;
            startloop:
            if (count < 5)
            {
                Console.WriteLine($"Count is: {count}");
                count++;
                goto startloop;
            }
            Console.WriteLine("Loop with goto is finished");
        }
       
    }
}
