using System;

namespace OOP.Exercises4
{
    public class Cat : Animal
    {

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="sex"></param>
        /// <param name="thisCat"></param>
        public Cat(string name, int age, string sex, string thisCat) : base(name, age, sex)
        {
            this.ThisCat = thisCat;
        }

        public string ThisCat { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Cat {0} say: meo meo...!", this.Name);
        }
    }
}