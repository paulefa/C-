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
            string userName, firstName, surName;
            double firstNumber, secondNumber;
            int dateOfBirth, todaysDate;

            Console.WriteLine("enter your firstname:");
            firstName = Console.ReadLine();

            Console.WriteLine("enter your surname:");
            surName = Console.ReadLine();

            userName = firstName + " " + surName;

            Console.WriteLine("Enter your date of birth:");
            dateOfBirth = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("enter today's date:");
            todaysDate = Convert.ToInt32(Console.ReadLine());

            int age = todaysDate - dateOfBirth;
            
            Console.WriteLine("welcome {0}! your age is {1} years", userName,age);
            Console.WriteLine();

            Console.WriteLine("Now give me a number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("now give me another number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The sum of {0} and {1} is {2}.", firstNumber, secondNumber, firstNumber + secondNumber);
            Console.WriteLine("The result of substracting {0} and {1} is {2}.", firstNumber, secondNumber, firstNumber - secondNumber);
            Console.WriteLine("The product of {0} and {1} is {2}.", firstNumber, secondNumber, firstNumber * secondNumber);
            Console.WriteLine("The result of dividing {0} and {1} is {2}.", firstNumber, secondNumber, firstNumber / secondNumber);
            Console.WriteLine("The remainder after dividing {0} by {1} is {2}.", firstNumber, secondNumber, firstNumber % secondNumber);

            Console.ReadKey();



            /*Console.WriteLine ("enter your first name");
            String firstname = Console.ReadLine();

            Console.WriteLine ("enter your surname");
            String lastname = Console.ReadLine();

            Console.WriteLine ("Hello {0} {1}", firstname , lastname);*/
        }
    }
}
