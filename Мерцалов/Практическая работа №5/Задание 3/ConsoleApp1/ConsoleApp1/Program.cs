using System;

public interface IFilter
{
    string Execute(string textLine);
}

public class DigitFilter : IFilter
{
    public string Execute(string textLine)
    {
        string result = "";
        foreach (char c in textLine)
        {
            if (!Char.IsDigit(c))
            {
                result += c;
            }
        }
        return result;
    }
}

public class LetterFilter : IFilter
{
    public string Execute(string textLine)
    {
        string result = "";
        foreach (char c in textLine)
        {
            if (!Char.IsLetter(c))
            {
                result += c;
            }
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IFilter digitFilter = new DigitFilter();
        IFilter letterFilter = new LetterFilter();

        string text = "123abc";
        Console.WriteLine(digitFilter.Execute(text));
        Console.WriteLine(letterFilter.Execute(text));
    }
}
