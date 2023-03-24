using System;
using System.Collections.Generic;

public interface IAnimal
{
    void MakeSound();
}

public class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

public class Bird : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Tweet!");
    }
}

public class Cow : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Moo!");
    }
}

public class Fish : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<IAnimal> animals = new List<IAnimal>();
        animals.Add(new Cat());
        animals.Add(new Dog());
        animals.Add(new Bird());
        animals.Add(new Cow());
        animals.Add(new Fish());

        foreach (IAnimal animal in animals)
        {
            PetAnimal(animal);
        }
    }

    static void PetAnimal(IAnimal animal)
    {
        animal.MakeSound();
    }
}
