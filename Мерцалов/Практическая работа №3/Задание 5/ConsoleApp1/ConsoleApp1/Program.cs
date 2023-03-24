using System;

public class SMS
{
    private string _message;
    private int _maxLength;
    private double _baseCost;
    private double _costPerChar;


public SMS(string message, int maxLength, double baseCost, double costPerChar)
    {
        _message = message;
        _maxLength = maxLength;
        _baseCost = baseCost;
        _costPerChar = costPerChar;
    }

    public string Message
    {
        get { return _message; }
        set { _message = value; }
    }

    public double CalculateCost()
    {
        if (_message.Length <= _maxLength)
        {
            return _baseCost;
        }
        else
        {
            int extraChars = _message.Length - _maxLength;
            double extraCost = extraChars * _costPerChar;
            return _baseCost + extraCost;
        }
    }
}

public class Program
{
    public static void Main()
    {
        SMS sms1 = new SMS("Fish", 10, 1.0, 0.1);
        Console.WriteLine($"Message: {sms1.Message}, Cost: {sms1.CalculateCost()}");

    
            SMS sms2 = new SMS("This is a long message", 10, 1.0, 0.1);
        Console.WriteLine($"Message: {sms2.Message}, Cost: {sms2.CalculateCost()}");

        sms2.Message = "Short";
        Console.WriteLine($"Message: {sms2.Message}, Cost: {sms2.CalculateCost()}");
    }
}