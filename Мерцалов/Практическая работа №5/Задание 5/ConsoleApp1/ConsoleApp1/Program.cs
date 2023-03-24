using System;
using System.Collections.Generic;

namespace Wizards
{
    public interface IWizard
    {
        string Name { get; }
        int Age { get; }
        void CastSpell();
    }
    public class FireWizard : IWizard
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public FireWizard(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void CastSpell()
        {
            Console.WriteLine("Fireball!");
        }
    }

    public class IceWizard : IWizard
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public IceWizard(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void CastSpell()
        {
            Console.WriteLine("Blizzard!");
        }
    }

    public class DarkWizard : IWizard
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public DarkWizard(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void CastSpell()
        {
            Console.WriteLine("Darkness!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IWizard> wizards = new List<IWizard>();
            wizards.Add(new FireWizard("Flamestrike", 50));
            wizards.Add(new IceWizard("Frostbite", 60));
            wizards.Add(new DarkWizard("Shadowmeld", 70));

            foreach (var wizard in wizards)
            {
                Console.WriteLine("Wizard Name: " + wizard.Name);
                Console.WriteLine("Wizard Age: " + wizard.Age);
                wizard.CastSpell();
                Console.WriteLine("");
            }
        }
    }
}