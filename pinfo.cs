/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dummy
{
    class pinfo
    {
        static void Main(string[] args)
        {
           int myinteger;
           double length = 1.8, width = 2.8;
           decimal perimeter = 9.7m;
           string mystring;
           myinteger = 17;
           mystring = "\"my intrger\" is ";
           Console.WriteLine(mystring + myinteger); Console.WriteLine();
           Console.WriteLine("{0} {1} {2}", mystring, myinteger, length); Console.WriteLine();
           Console.WriteLine("perimeter = " + perimeter);
           Console.WriteLine();
           Console.WriteLine("area = " + (length * width));

        }
    }
}
*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dummy
{
    class pinfo
    {
        static void Main(string[] args)
        {
            string var1;
            string var2 = "fred";
            string var3 = " james";
            var1 = var2 + var3;
            Console.WriteLine ("my name is " + var1);
        }
    }
}
*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dummy{
    class pinfo
    {
        static void Main (string[] args)
        {
            int var1, var2;
            var2 = 2;
            var1 = var2;
            Console.WriteLine ("var1 = {0} var2 = {1}", var1,var2);
            Console.WriteLine();

            //example1
            var2 = 2;
            var1 = ++var2;
            Console.WriteLine ("for example 1 "); Console.WriteLine();
            Console.WriteLine ("var1 = {0} var2 = {1}", var1,var2); Console.WriteLine();

            //example2
            var2 = 2;
            var1 = --var2;
            Console.WriteLine ("for example 2"); Console.WriteLine();
            Console.WriteLine ("var1 = {0} var2 = {1}", var1,var2); Console.WriteLine();

            //example3
            var2 = 2;
            var1 = var2++;
            Console.WriteLine ("for example 3"); Console.WriteLine();
            Console.WriteLine ("var1 = {0} var2 = {1}", var1,var2); Console.WriteLine();

            //example4
            var2 = 2;
            var1 = var2--;
            Console.WriteLine ("for example 4"); Console.WriteLine();
            Console.WriteLine ("var1 = {0} var2 = {1}", var1,var2); Console.WriteLine();
        }
    }
}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dummy
{
    class pinfo
    {     
           static void Main (string []args)
        {
            Console.WriteLine ("enter your first name");
            String firstname = Console.ReadLine();

            Console.WriteLine ("enter your surname");
            String lastname = Console.ReadLine();

            Console.WriteLine ("Hello {0} {1}", firstname , lastname);
        }
    }
}