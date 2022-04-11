using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dummy
{
    class Program
    {
        static void Main(/*string[] args*/)
        {

            /*double var1 = 12, var2 = 5;

            Console.WriteLine();
            Console.WriteLine("{0} = {1} is {2}", var1, var2, var1 = var2); Console.WriteLine();
            var1 = 12; var2 = 5;

            Console.WriteLine("{0} += {1} is {2}", var1, var2, var1 += var2); Console.WriteLine();
            var1 = 12; var2 = 5;

            Console.WriteLine("{0} -= {1} is {2}", var1, var2, var1 -= var2); Console.WriteLine();
            var1 = 12; var2 = 5; 

            Console.WriteLine("{0} *= {1} is {2}", var1, var2, var1 *= var2); Console.WriteLine();
            var1 = 12; var2 = 5;

            Console.WriteLine("{0} /= {1} is {2}", var1, var2, var1 /= var2); Console.WriteLine();
            var1 = 12; var2 = 5;

            Console.WriteLine("{0} %= {1} is {2}", var1, var2, var1 %= var2); Console.WriteLine();
            var1 = 12; var2 = 5;




            /* output text to screen
            //Console.WriteLine("Welcome to 120 days of coding");
            Console.WriteLine("Enter your name");
            /* This command prompts the user for input, which is
            *stored in a string variable called myName
            
            String myName = Console.ReadLine();
            Console.WriteLine("My Name is "+ myName);

            int myVal = 16;
            string myName = "Oladipupo Excellence";

            bool isLessThan10;

            isLessThan10 = myVal < 10;
            Console.WriteLine("isLessThan10 is {0}", isLessThan10); Console.WriteLine();

            bool isMyName, isTrue;

            isMyName = myName == "Oladipupo Excellence";
            isTrue = isMyName == true;
            Console.WriteLine("isMyName is {0} therefore isTrue is {1} ", isMyName, isTrue); Console.WriteLine();

            int result, op1, op2;
            op1 = 4;
            op2 = 5;

            result = op1 & op2;
            Console.WriteLine (op1 + " & " + op2 + " = " + result); Console.WriteLine();

            result = op1 | op2;
            Console.WriteLine (op1 + " | " + op2 + " = " + result); Console.WriteLine();

            result =  op1 ^ op2;
            Console.WriteLine (op1 + " ^ " + op2 + " = " + result); Console.WriteLine();

            result = ~ op2;
            Console.WriteLine (" ~ " + op2 + " = " + result); Console.WriteLine();

            int var1, var2 = 10, var3 = 2;

            var1 = var2 << var3;
            Console.WriteLine (var2 + " << " + var3 + " = " + var1); Console.WriteLine();

            var1 = var2 >> var3;
            Console.WriteLine (var2 + " >> " + var3 + " = " + var1); Console.WriteLine();

            //goto statements
            int myInterger = 5;
            goto myLabel;
            myInterger += 10; //this line of code will never execute
            myLabel:
            Console.WriteLine ("myInteger = {0}", myInterger); Console.WriteLine();

            //tenary or conditional operator
            Console.WriteLine("Enter an integer value: ");
            int myInteger = Convert.ToInt32(Console.ReadLine());

            string resultString;
            resultString = (myInteger < 10)? "Less than 10": "Greater than or equal to 10";
            Console.WriteLine("resultString is " + resultString);

            //if else
            Console.WriteLine ("Enter an integer value: ");
            int myInteger = Convert.ToInt32(Console.ReadLine());
            string resultString;
            if (myInteger < 10)
            {
                resultString = "Less than 10";
            }
            else
            {
                resultString = "Greater than or equal to 10";
            }
            Console.WriteLine("resultString is " + resultString);

            //if nested
            string comparison;
            Console.WriteLine ("Enter a number: ");
            double var1 = Convert.ToDouble (Console.ReadLine()); Console.WriteLine();
            Console.WriteLine ("Enter another number: ");
            double var2 = Convert.ToDouble (Console.ReadLine()); Console.WriteLine();
            if (var1 < var2)
                comparison = "less than";
            else
            {
                if (var1 == var2)
                    comparison = "equal to";
                else
                    comparison = "greater than";
            }
            Console.WriteLine("The first number is {0} the second number.", comparison);

            //example
            string action2 = "Sell";
            decimal priceGain = 1.8m;

            if (priceGain > 2m)
            {
                action2 = "Buy";
            }
                Console.WriteLine("priceGain is {0} then action2 is {1}", priceGain, action2);Console.WriteLine();
                //Console.WriteLine("priceGain is {0} then action2 is {1}", priceGain, action2);

                string action3 = "Do nothing";
                if (priceGain <= 2m)
                {
                    action3 = "Sell";
                }
                else
                {
                    action3 = "Buy";
                }
            Console.WriteLine("priceGain is {0} then action3 is {1}", priceGain, action3); Console.WriteLine();

            string action4 = null;
            Console.WriteLine ("Enter a number");
            decimal priceGain = Convert.ToDecimal(Console.ReadLine());
            if (priceGain <= 2m)
            {
                action4 = "Buy";
            }
            else if (priceGain > 2m && priceGain <= 3m)
            {
                action4 = "Do Nothing";
            }
            else
            {
                action4 = "Sell";
            }
        Console.WriteLine ("priceGain is {0} then action2 is {1}", priceGain, action4); Console.WriteLine();

        //grade
        int score;
        Console.WriteLine("Enter student score: ");
        score = Convert.ToInt32(Console.ReadLine());
        string result;

        if (score > 69 &&  score <= 100)
        {
            result = "A";
        }
        else if (score > 59 && score <= 69)
        {
            result = "B";
        }
        else if (score > 49 && score <= 59)
        {
            result = "C";
        }
        else if (score > 44 && score <= 49)
        {
            result = "D";
        }
        else
        {
            result = "F";
        }
        Console.WriteLine("Your score {0} is {1}: ", score, result);

        int a,b,c,x;
        double Sqrt;

        Console.WriteLine ("Enter Values for a: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine ("Enter Value for b: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine ("Enter Value for c: ");
        c = Convert.ToInt32(Console.ReadLine());

        int a,b,c;

        double d, x1,x2;
        Console.Write("\n\n");
        Console.Write("Calculate root of Quadratic Equation :\n");
        Console.Write("----------------------------------------");
        Console.Write("\n\n");
 
        Console.Write("Input the value of a : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the value of b : ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the value of c : ");
        c = Convert.ToInt32(Console.ReadLine());

        d=b*b-4*a*c;
        if(d==0)
   {
        Console.Write("Both roots are equal.\n");
        x1=-b/(2.0*a);
        x2=x1;
        Console.Write("First  Root Root1= {0}\n",x1);
        Console.Write("Second Root Root2= {0}\n",x2);
   }
        else if(d>0)
	{
	   Console.Write("Both roots are real and diff-2\n");

	   x1=(-b+Math.Sqrt(d))/(2*a);
	   x2=(-b-Math.Sqrt(d))/(2*a);

	   Console.Write("First  Root Root1= {0}\n",x1);
	   Console.Write("Second Root root2= {0}\n",x2);
	}
	    else
	    Console.Write("Root are imeainary;\nNo Solution. \n\n");

        double a, b, c;  
        double disc, deno, x1, x2;  
        Console.WriteLine("ENTER THE VALUES OF A,B,C...");  
        a = Convert.ToDouble(Console.ReadLine());  
        b = Convert.ToDouble(Console.ReadLine());  
        c = Convert.ToDouble(Console.ReadLine());  
        if (a == 0) {  
            x1 = -c / b;  
            Console.WriteLine("The roots are Linear:", x1);  
        } else {  
            disc = (b * b) - (4 * a * c);  
            deno = 2 * a;  
            if (disc > 0) {  
                Console.WriteLine("THE ROOTS ARE REAL AND DISTINCT ROOTS");  
                x1 = (-b / deno) + (Math.Sqrt(disc) / deno);  
                x2 = (-b / deno) - (Math.Sqrt(disc) / deno);  
                Console.WriteLine("THE ROOTS ARE... " + x1 + " and " + x2);  
            } else if (disc == 0) {  
                Console.WriteLine("THE ROOTS ARE REPEATED ROOTS");  
                x1 = -b / deno;  
                Console.WriteLine("THE ROOT IS...: " + x1);  
            } else {  
                Console.WriteLine("THE ROOTS ARE IMAGINARY ROOTS\n");  
                x1 = -b / deno;  
                x2 = ((Math.Sqrt((4 * a * c) - (b * b))) / deno);  
                Console.WriteLine("THE ROOT 1: " + x1 + "+i" + x2);  
                Console.WriteLine("THE ROOT 2:" + x1 + "-i" + x2);  
            }  
        }  
        Console.ReadLine();*/

            int a, b, c;
            double d, x1, x2;
            Console.WriteLine ("Enter the value of a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine ("Enter the value of b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine ("Enter the value of c: ");
            c = Convert.ToInt32(Console.ReadLine());

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                Console.WriteLine("Both roots are equal");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.WriteLine("first root {0}", x1);
                Console.WriteLine("second root {1}", x2);
            }
            else if (d > 0)
            {
                Console.WriteLine("Both roots are real");
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("first root {0}", x1);
                Console.WriteLine("second root {1}", x2);
            }
            else
            {
              Console.WriteLine("roots are imaginary");  
            }

        }
    }
}
