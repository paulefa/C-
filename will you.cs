using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace willyou
{
    class Program
    {
        static void Main()
        {
            //proposal
            /*string proposal, relationship;
            Console.WriteLine("Will you be my girlfriend?");
            proposal = Console.ReadLine();

            string answer = "yes";

            if (proposal == answer)
            {
                relationship = "Thank you, lets us make memories together";
            }
            else
            {
                relationship = "Why do you hate me?" ;
            }
            Console.WriteLine("{0}", relationship);

            //temperature
            double degree;
            Console.WriteLine("Enter degree:");
            degree = Convert.ToDouble(Console.ReadLine());
            string temperature;

            if (degree == 32)
            {
                temperature = "freezing point";
            }
            else if (degree > 32)
            {
                temperature = "Above freezing point";
            }
            else
            {
                temperature = "Below freezing point";
            }
            Console.WriteLine("Temperature is {0}", temperature);
            Main();

            //hours worked
            double hours;
            Console.WriteLine("Enter hours worked");
            hours = Convert.ToDouble(Console.ReadLine());
            double earnings;
            double newhours = hours - 12;
            if (hours <= 12)
            {
                earnings = hours * 50;
            }
            else
            {
                earnings = (12 * 50) + (90 * newhours);
            }
            Console.WriteLine("Your earnings is {0} Naira", earnings);
            Main();

            //leap year
            int year;
            Console.WriteLine ("Enter year: ");
            year = Convert.ToInt32(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)) Console.WriteLine("{0} is a leap year", year);
            else Console.WriteLine("{0} is not a leap year", year);
            Console.ReadLine();*/

            Console.WriteLine ("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            string leap;

            if (((year % 4 == 0) && (year % 100 != 0 )) || (year % 400 == 0))
            {
                leap = "is a leap year";
            }
            else
            {
                leap = "is not a leap year";
            }

            Console.WriteLine("{0} {1} ", year, leap);
            Main();
        }
    }
}



