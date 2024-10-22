using System;
namespace CS_Tests;

class Program
{
    static void Main(string[] args)
    {
        Fundament fnd = new Fundament();
        fnd.CheckOddOrEven(55);
        Console.WriteLine(fnd.GetAInterestingFact());
        fnd.SumTwoNumbers(54, 12);
        Console.WriteLine(fnd.SumTwoNumbersOfGivenType(59, 22)); 
        fnd.PrintFibonnaciSeries();
        Console.WriteLine(fnd.RecursiveFactorial(5));
        fnd.ReverseString("Det var en gang et brød i skogen");


        // Create a new instance of the Greeting class
        Greetings greetings = new Greetings();
        // English greeting
        greetings.SayHello();
        // Japanese greeting
        greetings.YoiTsuitachi();
        //German greeting;
        greetings.GermanHello();

    }
}
