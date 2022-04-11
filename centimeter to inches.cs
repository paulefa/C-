// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace man
{
    class Program
    {
        static void Main ()
        {   
            //Convert centimeter to inches
            /*double centimeter, inches;

            Console.WriteLine("Enter centimeter");
            centimeter = Convert.ToDouble (Console.ReadLine());

            inches = centimeter/2.54;
            Console.WriteLine("{0} inches", inches);

            //optain 4 int values and display the product
            int firstno, secondno, thirdno, fourthno, product;

            Console.WriteLine("Input first value:");
            firstno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second value:");
            secondno= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input Third value");
            thirdno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input fourth value:");
            fourthno = Convert.ToInt32(Console.ReadLine());

            product = firstno*secondno*thirdno*fourthno;
            Console.WriteLine("The product is: " + product);

            //calculate the pythagoras theorem
            double distance, x1, x2, y1, y2, x, y;

            Console.WriteLine("Enter value for x1:");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value fof x2:");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value for y1:");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for y2:");
            y2 = Convert.ToDouble(Console.ReadLine());

            x = (x2-x1)*(x2-x1);
            y = (y2-y1)*(y2-y1);
            distance = (x+y);
            Console.WriteLine(Math.Sqrt(distance).ToString());

            Main();

            //celsuis to fahrenheit
            double celsuis, fahrenheit;

            Console.WriteLine("Input Celsuis: ");
            celsuis = Convert.ToDouble(Console.ReadLine());

            fahrenheit = celsuis * 9/5 + 32;
            Console.WriteLine("{0} fahrenheit", fahrenheit);

            Main();

            //pounds to kilogram
            double pounds, kilo;

            Console.WriteLine("Input pounds: ");
            pounds = Convert.ToDouble(Console.ReadLine());

            kilo = pounds/2.205;
            Console.WriteLine("{0} kilogram(s)", kilo);

            Main();*/

            //surface area and volume
            double r, sarea, vol;
            double PI = 3.14159265;

            Console.WriteLine("Enter radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            //surface area = 4 pi r^2
            //volume of sphere = 4/3 pi r^3
            //double sqr = Math.Pow(number,2);

            sarea = 4*PI*r*r;
            vol = (4*PI*r*r*r)/3;

            Console.WriteLine("The surface area is: " + sarea);
            Console.WriteLine("The volume is: " + vol);

            Main();

        }
    } 
}