using System;

public class Color
{
    private int red;
    private int green;
    private int blue;

    public Color(int r, int g, int b)
    {
        red = r;
        green = g;
        blue = b;
    }

    public int Red
    {
        get { return red; }
        set { red = value; }
    }

    public int Green
    {
        get { return green; }
        set { green = value; }
    }

    public int Blue
    {
        get { return blue; }
        set { blue = value; }
    }

    public override string ToString()
    {
        return String.Format("({0}, {1}, {2})", red, green, blue);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Color myColor = new Color(255, 0, 0);
        Console.WriteLine("My color is " + myColor.ToString());
        myColor.Green = 255;
        Console.WriteLine("My color is " + myColor.ToString());
        Console.ReadLine();
    }
}
