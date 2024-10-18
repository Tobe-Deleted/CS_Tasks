public interface IFundament
{
    /// <summary>
    /// Sums two numbers together, in void, we can specify if these numbers are integers, doubles or long
    /// </summary>
    void SumTwoNumbers(int a, int b);

    /// <summary>
    /// sums together two numbers that it recieves as parameter arguments
    /// </summary>
    /// <param name="a">the value of a</param>
    /// <param name="b">the value of b</param>
    /// <returns>a + b</returns>
    double SumTwoNumbersOfGivenType(double a, double b);

    /// <summary>
    /// check whether a number is even (divisible by two) or odd
    /// </summary>
    void CheckOddOrEven(double a);

    /// <summary>
    /// A method that returns a interesting fact, that the user of the program can define as a parameter argument
    /// </summary>
    /// <param name="fact">a interesting fact</param>
    /// <returns>a fact of type: string</returns>
    string GetAInterestingFact(string fact);

/// <summary>
/// Writes out the 10 first digits of the Fibonnaci series
/// </summary>
    public void PrintFibonnaciSeries();

    /// <summary>
    /// Reverses given string
    /// </summary>
    /// <returns>str reversed</returns>
    public string ReverseString(string str);

    /// <summary>
    /// gives the factorial of a given number
    /// </summary>
    /// <param name="n"></param>
    /// <returns>n!</returns>
    public int RecursiveFactorial(int n);
}
