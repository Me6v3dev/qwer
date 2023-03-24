using System;
using System.Collections.Generic;

public interface IHello
{
    void SayHello();
}

public class English : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Hello!");
    }
}

public class French : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Bonjour!");
    }
}

public class Spanish : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Hola!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<IHello> hellos = new List<IHello>();
        hellos.Add(new English());
        hellos.Add(new French());
        hellos.Add(new Spanish());

        foreach (IHello hello in hellos)
        {
            hello.SayHello();
        }
    }
}
