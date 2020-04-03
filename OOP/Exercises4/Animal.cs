using System.Linq;
using System.Threading;

namespace OOP.Exercises4
{
    public abstract class Animal : ISound
    {
        private string name;
        private double age;
        private string sex;

        /// <summary>
        /// Constructor Animal
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="sex"></param>
        protected Animal(string name, double age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        /// <summary>
        /// Properties
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw  new  AbandonedMutexException($"Nam can not be null or empty");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public double Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new AbandonedMutexException($"Age can not be < 0");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Sex
        {
            get { return this.sex; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new AbandonedMutexException($"Sex can not be null or empty");
                }
                else
                {
                    this.sex = value;
                }
            }
        }

        public abstract void Sound();

        /// <summary>
        /// Calculator Average Age Animal
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public static double AverageAge(Animal[] animal)
        {
            double result;

            var sum = animal.Aggregate<Animal, double>(0, (current, item) => current + item.age);

            try
            {
                result = sum / animal.Length;
            }
            catch (System.Exception ex)
            {
              throw new AbandonedMutexException(ex.ToString());
            }
            return result;
        }
    }
}