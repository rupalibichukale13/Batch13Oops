using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{

    public enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        Octomber,
        November,
        December
    }

    internal class EnumAssignment
    {
        static void Main()
        {
            Months year = Months.January;
            switch (year)
            {
                case Months.January:
                    Console.WriteLine("January");
                    break;

                case Months.February:
                    Console.WriteLine("February");
                    break;
                case Months.March:
                    Console.WriteLine("March");
                    break;
                case Months.April:
                    Console.WriteLine("April");
                    break;
                case Months.May:
                    Console.WriteLine("May");
                    break;
                case Months.June:
                    Console.WriteLine("June");
                    break;
                case Months.July:
                    Console.WriteLine("July");
                    break;
                case Months.August:
                    Console.WriteLine("August");
                    break;
                case Months.September:
                    Console.WriteLine("September");
                    break;
                case Months.Octomber:
                    Console.WriteLine("Octomber");
                    break;
                case Months.November:
                    Console.WriteLine("November");
                    break;
                case Months.December:
                    Console.WriteLine("December");
                    break;


            }
            if (year == Months.January)
            {
                Console.WriteLine("This is First Month of Year");
            }
            else if( year == Months.January)
            {
                Console.WriteLine("This Is First month of year");
            }
            else
            {
                Console.WriteLine("Month of year");
            }



            }
        }
    }

