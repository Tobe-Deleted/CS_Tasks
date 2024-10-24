using System.Collections.Generic;
using System.Linq;
using System;
public class Fundament : IFundament
{
    public void CheckOddOrEven(double a)
    {
        if (a % 2 == 0) Console.WriteLine(a + "is Even");
        else Console.WriteLine(a + " is Odd");
    }

    public string GetAInterestingFact()
    {
    Random rnd = new Random();
    int n = rnd.Next(0, 10);
    Console.Write("Interesting fact: ");
    switch(n)
    {
        case 0:
            return "A German shepherd named Talero stayed next to the body of his owner for 23 days after he had died in a snow storm. He prevented animals from attacking the body and tried to keep his owner warm by sleeping by his side.";
        case 1:
            return "The universe is estimated to be 13.8 billion years old";
        case 2:
            return "The oldest remains of a domestic cat is estimated to be around 10.000 years old";
        case 3:
            return "The Richat structure, often named 'eye of africa', can be seen from space";
        case 4:
            return "Javascript was named Javascript because Java was a popular language at the time. They have nothing to do with each other";
        case 5:
            return "The field of quantum physics was established after we discovered that a particle could exist in two different states at the same time";
        case 6:
            return "In South Korea, 14th of April is unofficially celebrated as valentines day for single people";
        case 7:
            return "Tenochtitlan, the capital of the Aztec empire, used to be a city on an island in the middle of a lake. Today the lake is gone.";
        case 8:
            return "Ambita was the first company, in Norway, to offer a service where you can deliver 'skifteattest' electronically. This function was introduced in september 2024";
        case 9:
            return "The tallest mountain on Mars is 21km tall";
        default: return "error";

    }
    }

    public void SumTwoNumbers(int a, int b) 
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    public double SumTwoNumbersOfGivenType(double a, double b) =>  a + b;
    


    // Extra challenges

    public int PrintFibonnaciSeries(int n)
    {
        // TODO: Implement the Fibonacci sequence
        
        if (n <= 1) 
        {
            return n;
        }
		return PrintFibonnaciSeries(n - 1) + PrintFibonnaciSeries(n -2);
	}
    

    public string ReverseString(string str) => string.Concat(str.Reverse());
        // TODO: reverse the given string
    

    public int RecursiveFactorial(int n)
    {
        // Todo: Implement a recursive method(a method that calls itself within its own function scope)
        // To Check the factorial of a number(norsk: Fakultet) we look at n!, where n = n * 1 * 2 * 3...
        if (n == 0)
        {
            return 1;
        }
        return n * RecursiveFactorial(n - 1);
    }


}
