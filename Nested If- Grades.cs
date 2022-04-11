using System;
class prog{
    public static void Main(){
        int a;
        Console.WriteLine("Enter a Grade Score: ");
        a =  Convert.ToInt32(Console.ReadLine());
        if(a>40 && a=50){
            Console.WriteLine("Your Grade is A");
        }
        else if(a>30 && a=40){
            Console.WriteLine("Your Grade is B");
        }
        else if(a>20 && a=30){
            Console.WriteLine("Your Grade is C");
        }
        else if(a>10 && a=20){
            Console.WriteLine("Your Grade is D");
        }
        else{
            Console.WriteLine("Your Grade is F");
        }
        Console.ReadLine();
    }
}