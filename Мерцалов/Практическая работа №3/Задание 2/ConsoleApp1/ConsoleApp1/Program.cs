using System;

public class SmsMessage
{
    private string messageText;
    private decimal price;

    public SmsMessage(string text)
    {
        if (text.Length > 250)
        {
            messageText = text.Substring(0, 250);
        }
        else
        {
            messageText = text;
        }
        if (messageText.Length <= 65)
        {
            price = 1.5M;
        }
        else
        {
            int extraChars = messageText.Length - 65;
            price = 1.5M + (decimal)(extraChars * 0.5);
        }
    }

    public string MessageText
    {
        get { return messageText; }
    }

    public decimal Price
    {
        get { return price; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SmsMessage myMessage = new SmsMessage("Hello, this is a test message");
        Console.WriteLine("Message text: " + myMessage.MessageText);
        Console.WriteLine("Price: " + myMessage.Price);
        Console.ReadLine();
    }
}
