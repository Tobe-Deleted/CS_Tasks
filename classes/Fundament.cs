using System.Collections.Generic;
using System.Linq;
using System;
public class Fundament : IFundament
{
    public void CheckOddOrEven(double a)
    {
        if (a%2==0) Console.WriteLine("Even");
        else Console.WriteLine("Odd");
    }

    public string GetAInterestingFact(string fact)
    {
        return "The universe is estimated to be 13.4 billion years old";
    }

    public void SumTwoNumbers(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    public double SumTwoNumbersOfGivenType(double a, double b)
    {
        return a + b;
    }


    // Extra challenges

    public void PrintFibonnaciSeries()
    {
        // TODO: Implement the Fibonacci sequence
        int a = 0;
        int b = 1;
        int c;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(a);
            c = a + b;
            a = b;
            b = c;
        }
    }

    public string ReverseString(string str)
    {
        // TODO: reverse the given string
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return string.Join("", charArray);
    }

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
