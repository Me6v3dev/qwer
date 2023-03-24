using System;

public class QuadraticEquationSolver
{
    private double a;
    private double b;
    private double c;
    private double root1;
    private double root2;

    public QuadraticEquationSolver(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    private double CalculateDiscriminant()
    {
        return b * b - 4 * a * c;
    }

    public void CalculateRoots()
    {
        double discriminant = CalculateDiscriminant();
        if (discriminant >= 0)
        {
            root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        }
        else
        {
            root1 = double.NaN;
            root2 = double.NaN;
        }
    }

    public double GetRoot1()
    {
        return root1;
    }

    public double GetRoot2()
    {
        return root2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите коэффициенты a, b и c для квадратного уравнения ax^2 + bx + c = 0:");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        QuadraticEquationSolver solver = new QuadraticEquationSolver(a, b, c);
        solver.CalculateRoots();

        Console.WriteLine("Корни уравнения: ");
        Console.WriteLine($"x1 = {solver.GetRoot1()}");
        Console.WriteLine($"x2 = {solver.GetRoot2()}");

        Console.ReadKey();
    }
}
