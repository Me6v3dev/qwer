using System;

class Wizard
{
    public string Name { get; set; }
    public int Mana { get; set; }

    public Wizard(string name, int mana)
    {
        Name = name;
        Mana = mana;
    }

    public void CastSpell(string spellName, int manaCost)
    {
        if (Mana < manaCost)
        {
            Console.WriteLine($"Для использования {spellName} не хватает {manaCost - Mana} единиц маны. Хлебните зелья!");
        }
        else
        {
            Mana -= manaCost;
            Console.WriteLine($"{Name} колдует! {spellName}");
        }
    }
}

class Spell
{
    public string Name { get; set; }
    public int ManaCost { get; set; }

    public Spell(string name, int manaCost)
    {
        Name = name;
        ManaCost = manaCost;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Wizard wizard = new Wizard("Гарри Поттер", 10);
        Spell spell = new Spell("Огненный шар", 5);

        wizard.CastSpell(spell.Name, spell.ManaCost);

        Console.ReadKey();
    }
}
