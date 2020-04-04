using System;

namespace OOP.Exercises4
{
    public class Frog : Animal
    {
        public Frog(string name, int age, string sex) : base(name, age, sex)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Frog {0} say: op op...!", this.Name);
        }
    }
}