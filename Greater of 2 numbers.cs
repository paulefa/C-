using System;
class prog
{
    public static void Main()
    {
        int a, b;
        Console.WriteLine("Enter 2 numbers: ");
        a =  Convert.ToInt32(Console.ReadLine());
        b =  Convert.ToInt32(Console.ReadLine());
        if(a>b){
            Console.WriteLine("{0} is the greatest number, a");
        }
        else{
            Console.WriteLine("{0} is the greatest number, b");
        }
        Console.ReadLine();
    }
}