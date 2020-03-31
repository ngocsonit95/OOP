using System;

namespace OOP.Exercises4
{
    public class Dog : Animal
    {

        public Dog(string name, int age, string sex, string thisDog) : base(name, age, sex)
        {
            this.ThisDog = thisDog;
        }

        public string ThisDog { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Dog {0} say gau gau...!", this.Name);
        }
    }
}