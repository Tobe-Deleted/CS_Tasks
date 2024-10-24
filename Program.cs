using System;
namespace CS_Tests;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the Greeting class
        Greetings greetings = new Greetings();
        // English greeting
        greetings.SayHello();
        // Japanese greeting
        greetings.YoiTsuitachi();
        //German greeting;
        greetings.GermanHello();

        Fundament fnd = new Fundament();
        fnd.CheckOddOrEven(55);
        Console.WriteLine(fnd.GetAInterestingFact());
        fnd.SumTwoNumbers(54, 12);
        Console.WriteLine($"The sum of 59 and 22 is {fnd.SumTwoNumbersOfGivenType(59, 22)}"); 
        
        bool ValidInput = false;
        int fib = 0;
        while (!ValidInput)
        {
                    
            try
            {
                Console.Write("Fibonacci digit number:");
                fib = Convert.ToInt32(Console.ReadLine());
                ValidInput = true;
            }
            catch(FormatException)
            {
                Console.WriteLine("input must be a number");
                ValidInput = false;
            }
        }
        Console.WriteLine($"The digit number {fib} of the fibonacci sequence is: {fnd.PrintFibonnaciSeries(fib)}");

        Console.WriteLine(fnd.RecursiveFactorial(5));
        Console.WriteLine(fnd.ReverseString("Det var en gang et brød i skogen"));



    }
}
