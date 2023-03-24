using System;

class Car
{
    public string Name { get; set; }
    public int MaxSpeed { get; set; }

    public Car(string name, int maxSpeed)
    {
        Name = name;
        MaxSpeed = maxSpeed;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Car {Name} with max speed {MaxSpeed} km/h.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car[] cars = new Car[4];

        cars[0] = new Car("Ferrari", 300);
        cars[1] = new Car("Lamborghini", 320);
        cars[2] = new Car("Porsche", 310);
        cars[3] = new Car("Bugatti", 400);

        Console.WriteLine("Гонка началась!");

        foreach (Car car in cars)
        {
            car.PrintInfo();
        }

        Console.WriteLine();

        Random random = new Random();
        int raceDistance = 100;

        int[] distances = new int[cars.Length];
        int winnerIndex = -1;
        int maxDistance = 0;

        for (int i = 1; i <= raceDistance; i++)
        {
            Console.WriteLine($"Дистанция: {i} km");

            for (int j = 0; j < cars.Length; j++)
            {
                int speed = random.Next(cars[j].MaxSpeed - 50, cars[j].MaxSpeed + 50);
                distances[j] += speed;
                Console.WriteLine($"Автомобиль  {cars[j].Name} движется со скоростью {speed} km/h. Общее расстояние: {distances[j]} km.");

                if (distances[j] > maxDistance)
                {
                    maxDistance = distances[j];
                    winnerIndex = j;
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine("Гонка окончена!");

        Console.WriteLine($"Победителем становится  {cars[winnerIndex].Name} с расстоянием  {maxDistance} km!");
    }
}


/* Все задания в одном коде! P.S. строго не судите. Спасибо!😊*/