using System;

class Orc
{
    public static int Gold { get; private set; } = 0;
    public static int OrcCount { get; private set; } = 0;

    public Orc()
    {
        OrcCount++;
        Gold += OrcCount * 2;
        if (OrcCount > 5)
        {
            Gold -= 2;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Orc orc1 = new Orc();
        Console.WriteLine($"Gold: {Orc.Gold}"); // Output: Gold: 2

        Orc orc2 = new Orc();
        Console.WriteLine($"Gold: {Orc.Gold}"); // Output: Gold: 6

        Orc orc3 = new Orc();
        Console.WriteLine($"Gold: {Orc.Gold}"); // Output: Gold: 10

        Orc orc4 = new Orc();
        Console.WriteLine($"Gold: {Orc.Gold}"); // Output: Gold: 12

        Orc orc5 = new Orc();
        Console.WriteLine($"Gold: {Orc.Gold}"); // Output: Gold: 14

        Orc orc6 = new Orc();
        Console.WriteLine($"Gold: {Orc.Gold}"); // Output: Gold: 14
    }
}
