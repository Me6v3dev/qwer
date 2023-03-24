using System;

public class NumberIncrementer
{
    private int p = 0;

    public bool SetNumber(int number)
    {
        if (number == p + 1)
        {
            p = number;
            return true;
        }
        else
        {
            p = 0;
            return false;
        }
    }

    public int GetExpectedNumber()
    {
        return p + 1;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        NumberIncrementer incrementer = new NumberIncrementer();

        Console.WriteLine("Введите число 1:");
        int number = int.Parse(Console.ReadLine());

        while (true)
        {
            if (incrementer.SetNumber(number))
            {
                Console.WriteLine("Введите число " + incrementer.GetExpectedNumber() + ":");
                number = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Неверное число . Начинать все сначала.");
                Console.WriteLine("Введите число 1:");
                number = int.Parse(Console.ReadLine());
            }
        }
    }
}
