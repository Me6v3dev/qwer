using System;

public interface IShape
{
    void Draw(int size);
}

public class VerticalLine : IShape
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("|");
        }
    }
}

public class HorizontalLine : IShape
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }
}

public class Square : IShape
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        IShape shape1 = new VerticalLine();
        shape1.Draw(5);

        IShape shape2 = new HorizontalLine();
        shape2.Draw(10);

        IShape shape3 = new Square();
        shape3.Draw(8);
    }
}
