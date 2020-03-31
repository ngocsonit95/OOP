using System;

namespace OOP.Exercises4
{
    internal class TomCat : Cat
    {
        public TomCat(string name, int age, string thisCat) : base(name, age, "male", thisCat)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Tomcat {0} say: meo meo", this.Name);
        }
    }
}