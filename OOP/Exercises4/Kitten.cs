using System;

namespace OOP.Exercises4
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, string thisCat) : base(name, age, "female", thisCat)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Kitten {0} say: meo meo", this.Name);
        }
    }
}