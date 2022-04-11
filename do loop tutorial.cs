/*namespace MyNamespace
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine("{0}", i++);
            } while (i <= 10);

            //sum of 1 - 10 in a column as 1 3 6 ....55
            int i = 1;
            int sum = 0;
            do
            {
                Console.WriteLine ("{0}", sum += i++); Console.WriteLine();
            } while (i <= 10);
            Console.WriteLine("this will find the sum of 1 to 10 as 55"); Console.WriteLine();

            i = 1;
            sum = 0;
            do
            {
                sum = sum + i; //this is the same as sum += i;
                ++i;           // the same as i = i + 1;
            } while (i <= 10);
            Console.WriteLine("The sum of 1 to 10 is {0}", sum); Console.WriteLine();

            double balance, interestRate, targetBalance;

            Console.WriteLine ("What is your current balance? ");
            balance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine ("What is your current annual intrest rate (in %)? ");
            interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;

            Console.WriteLine ("What balance would you like to have? ");
            targetBalance = Convert.ToDouble(Console.ReadLine());

            int totalYears = 0;
            /*do
            {
                balance *= interestRate;
                ++ totalYears;
            } while (balance < targetBalance);

            while (balance < targetBalance);
            {
                balance *= interestRate;
                ++ totalYears;
            }
            Console.WriteLine ("In {0} year{1} you will have a balance of {2}.", totalYears, totalYears == 1 ? " ": "s", balance );

            int i = 1;
            int sum = 0;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(sum += i); 
            }

            ushort destinationVar;
            char sourceVar = 'a';

            destinationVar = sourceVar;
            Console.WriteLine();
            Console.WriteLine(" sourceVal: {0}", sourceVar); Console.WriteLine();
            Console.WriteLine("destinationVar: {0}", destinationVar); Console.WriteLine();

            //exception handling
            enum daysOfTheWeek : byte
            {
                Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday,
                Error = 10
            }
            class Enumeration
            {
                static void Main()
                {
                    daysOfTheWeek day;
                    Console.WriteLine ("Enter days of the week:");
                    string tday = Console.ReadLine();
                    switch (tday)
                    {
                        case "M":
                            day = daysOfTheWeek.Monday; break;
                        case "T":
                            day = daysOfTheWeek.Tuesday; break;
                        case "W":
                            day = daysOfTheWeek.Wednesday; break;
                        case "Th":
                            day = daysOfTheWeek.Thursday; break;
                        default:
                            day = daysOfTheWeek.Error; break;
                    }
                    Console.WriteLine(day);
                }
            }

//        }
//    }
//}

            class exceptionsDemo
            {
                static void Main()
                {
                    string filename = "WrongTextFile.txt";
                    ReadFile (filename);
                }
                static void ReadFile(string filename)
                {
                    TextReader reader = new StreamReader(filename);
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                    reader.Close();
                }
            }*/

            namespace MyNamespace
            {
                public class MyClass
                {
                    public static void Main()
                    {
                        //bool numbersOk = false;
                        /*double var1, var2;
                        var1 = 0;
                        var2 = 0;

                        //while (!numbersOk)
                        //{
                            Console.WriteLine ("Enter Var1: ");
                            var1 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine ("Enter Var2: ");
                            var2 = Convert.ToDouble(Console.ReadLine());
                        //}
                        if ((var1 > 10) && (var2 > 10 ))
                        {
                            Console.WriteLine ("Both values are greater than 10");
                        }
                        else if ((var1 < 10) && (var2 < 10))
                        {
                            //numbersOk = true;
                            Console.WriteLine ("both values are less than 10");
                        }
                        else if (var1 > 0 && var2 > 10)
                        {
                            Console.WriteLine("Value 1 is less than 10");
                        }
                        else if (var1 > 10 && var2 > 1 )
                        {
                            Console.WriteLine("Value 2 is less than 10");
                        }
                        Console.WriteLine ("you entered {0} and {1}", var1, var2);
                        //Console.ReadKey();
                        Main();*/

                        /*int i = 1;
                        int sum = 0;
                        do
                        {
                            Console.WriteLine ("{0}", sum += i++); Console.WriteLine();
                        }           
                        while (i <= 10);
                            Console.WriteLine("this will find the sum of 1 to 10 as 55"); Console.WriteLine();*/

                        int i = 1;
                        int sum = 0;
                        do
                        {
                        sum = sum + i; //this is the same as sum += i;
                        ++i;           // the same as i = i + 1;
                        } 
                        while (i <= 10);
                        Console.WriteLine("The sum of 1 to 10 is {0}", sum); Console.WriteLine();

                    }
                }
            }
