using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        RandomNumberGenerator generator = new RandomNumberGenerator(100);
        Console.WriteLine("Random Numbers:");
        Console.WriteLine(string.Join(", ", generator.Numbers));
        Console.WriteLine($"Mean: {generator.Mean}");
        Console.WriteLine($"Variance: {generator.Variance}");
        Console.WriteLine($"Standard Deviation: {generator.StdDeviation}");
        Console.WriteLine($"Median: {generator.Median}");
    }
}

public class RandomNumberGenerator
{
    private int _length;
    private List<double> _numbers;
    private double? _mean;
    private double? _variance;
    private double? _stdDeviation;
    private double? _median;

    public RandomNumberGenerator(int length)
    {
        _length = length;
        _numbers = new List<double>();
        GenerateRandomNumbers();
    }

    public List<double> Numbers
    {
        get { return _numbers; }
    }

    public double Mean
    {
        get
        {
            if (_mean == null)
            {
                _mean = _numbers.Average();
            }
            return _mean.Value;
        }
    }

    public double Variance
    {
        get
        {
            if (_variance == null)
            {
                double mean = Mean;
                _variance = _numbers.Sum(number => Math.Pow(number - mean, 2)) / (_length - 1);
            }
            return _variance.Value;
        }
    }

    public double StdDeviation
    {
        get
        {
            if (_stdDeviation == null)
            {
                _stdDeviation = Math.Sqrt(Variance);
            }
            return _stdDeviation.Value;
        }
    }

    public double Median
    {
        get
        {
            if (_median == null)
            {
                List<double> sortedNumbers = Numbers.OrderBy(number => number).ToList();
                if (_length % 2 == 0)
                {
                    _median = (sortedNumbers[_length / 2 - 1] + sortedNumbers[_length / 2]) / 2;
                }
                else
                {
                    _median = sortedNumbers[_length / 2];
                }
            }
            return _median.Value;
        }
    }

    private void GenerateRandomNumbers()
    {
        Random random = new Random();
        for (int i = 0; i < _length; i++)
        {
            _numbers.Add(random.NextDouble());
        }
    }
}
