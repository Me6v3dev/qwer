using System;

class Package
{
    public string Description { get; set; }
    public int Weight { get; set; }

    public Package(string description, int weight)
    {
        Description = description;
        Weight = weight;
    }
}

class DeliveryService
{
    public int WeightLimit { get; set; }
    public int TotalWeight { get; set; }

    public DeliveryService(int weightLimit)
    {
        WeightLimit = weightLimit;
        TotalWeight = 0;
    }

    public void SendPackage(Package package)
    {
        if (TotalWeight + package.Weight > WeightLimit)
        {
            Console.WriteLine($"Превышен лимит веса отправленных посылок ({WeightLimit} кг). Отправка прервана.");
        }
        else
        {
            TotalWeight += package.Weight;
            Console.WriteLine($"Посылка отправлена: {package.Description} ({package.Weight} кг)");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        DeliveryService deliveryService = new DeliveryService(10);

        Package package1 = new Package("Книга", 2);
        deliveryService.SendPackage(package1);

        Package package2 = new Package("Кошелек", 1);
        deliveryService.SendPackage(package2);

        Package package3 = new Package("Телевизор", 15);
        deliveryService.SendPackage(package3);

        Console.ReadKey();
    }
}
