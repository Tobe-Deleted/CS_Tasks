// Example class Greetings, this implements the example interface IGreetings.cs

using System.Runtime.Versioning;

public class Greetings : IGreetings
{
    /// <summary>
    /// Short greeting in spanish
    /// </summary>
    public void DecirHola()
    {
        Console.WriteLine($"Hola!");
    }
    /// <summary>
    /// Short greeting in german
    /// </summary>
    public void SagHallo()
    {
        Console.WriteLine("Hallo!");
    }
    /// <summary>
    /// Short greeting in english
    /// </summary>
    public void SayHello()
    {
        Console.WriteLine("Hello!");
    }
    /// <summary>
    /// Short greeting in norwegian & danish
    /// </summary>
    public void SiHei()
    {
        Console.WriteLine("Hei!");
    }
    /// <summary>
    /// Short greeting in japanese
    /// </summary>
    public void YoiTsuitachi()
    {
        Console.WriteLine("Konichiwa!");
    }

    public void GermanHello()
    {
        Console.WriteLine("Guten Tag!");
    }
}