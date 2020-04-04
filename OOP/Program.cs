using OOP.Exercises1;
using OOP.Exercises2;
using OOP.Exercises3;
using OOP.Exercises4;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    internal static class Program
    {
        private static void Main()
        {
            #region Exerises-1

            var goodStudent = new Students("Thanh Mai", "Nguyen", 1);
            goodStudent.AddComment("Thanh Mai is a good student");

            var badStudent = new Students("Tan Phuc", "Huynh", 2);
            badStudent.AddComment("Tan Phuc is a bad student");

            var ivaStudent = new Students("Thanh Mai", "Nguyen", 1);
            ivaStudent.AddComment("Thanh Mai is poor student");

            var mathematics = new Discipline("Mathematics", 2, 2);
            mathematics.AddComment("Thanh Mai like Mathematics");

            var physics = new Discipline("Physics", 8, 4);
            var chemistry = new Discipline("Chemistry", 3, 2);
            var economy = new Discipline("Economy", 1, 1);

            var mariaTeacher = new Teachers("Dinh Hai Son", "Phan", new List<Discipline> { mathematics, physics, chemistry });
            mariaTeacher.AddComment("Dinh Hai Son Nguyen  is a great teacher");

            var teacher = new Teachers("Minh Quang", "Le", new List<Discipline> { economy });
            var firstClass = new Class(new List<Students> { goodStudent, badStudent }, new List<Teachers> { mariaTeacher }, "A");
            var secondClass = new Class(new List<Students> { ivaStudent }, new List<Teachers> { teacher }, "B");

            Console.WriteLine("First class {0}", firstClass);

            Console.WriteLine("Second name {0}", secondClass);

            #endregion Exerises-1

            #region Exerises-2

            var studentsList = new List<Student>
            {
                new Student("Thuy Anh", "Do", 18),
                new Student("Thao Anh", "Pham", 15),
                new Student("Quang Huy", "Pham", 24),
                new Student("Thien Bao", "Vu", 17),
                new Student("Ngoc Binh", "Doan ", 25),
                new Student("Ngoc Bao Chau", "Truong", 19),
                new Student("Chi Dung", "Do", 20),
                new Student("Bach Duong", "Nguyen ", 22),
                new Student("Manh Dat", "Nguyen", 16),
                new Student("Truong Phuc Hai", "Trinh", 21),
            };

            // List of 10 workers
            var workersList = new List<Worker>
           {
                new Worker("Manh Hieu", "Doan", 555, 4),
                new Worker("Van Huy", "Pham", 900, 12),
                new Worker("Thanh Mai", "Nguyen", 100, 40),
                new Worker("Nguyen Hung", "Do", 1021, 50),
                new Worker("Quang Hung", "Nguyen", 200, 21),
                new Worker("Thanh Luong", "Le", 111, 10),
                new Worker("Hoang Hai Nam", "Hoang", 1000, 9),
                new Worker("Bao Nam", "Le", 11, 11),
                new Worker("Hai Nam", "Nguyen", 88, 8),
                new Worker("Nhu Ngoc", "Nguyen", 1111, 11)
            };

            // Call methods
            SortStudentByGrade(studentsList);
            SortWorkersByMoneyPerHours(workersList);

            // Merge studentsList and workersList
            var mergeList = new List<Human>();
            mergeList.AddRange(studentsList);
            mergeList.AddRange(workersList);

            // Call method
            SortMergedList(mergeList);

            #endregion Exerises-2

            #region Exerises-3

            // Array of shapes
            var shapes = new Shape[]
             {
                new Triangle(3.10, 5.2),
                new Rectangle(11, 20),
                new Circle(6.9)
             };

            // Calculate surface for different shapes
            foreach (var item in shapes)
            {
                Console.WriteLine("{0}= {1}", item.GetType().Name, item.CalculateSurface());
            }

            #endregion Exerises-3

            #region Exerises-4

            //Create array Dog animal
            Animal[] dogs = {
                new Dog("DogBlack", 3, "male", "Black"),
                new Dog("DogYellow", 2, "male", "Yellow"),
                new Dog("DogRed", 6, "female", "Red"),
                new Dog("DogWhite", 4, "female", "White")
               };

            // Array of cats
            Animal[] cats = {
                new Cat("Tom", 2, "male", "Max"),
                new Cat("Jenny", 5, "female", "Sona"),
                new Cat("Jacky", 1, "female", "Lukas"),
                new Cat("Babby", 9, "male", "Cake")
            };
            var tomCat = new TomCat("Siro", 9, "telerik");
            var kitten = new Kitten("kiki", 1, "Crack");

            // Array of frogs
            Animal[] frogs = {
                new Frog("FrogBlack", 2, "male"),
                new Frog("FrogRed", 1, "female"),
                new Frog("FrogYellow", 3, "male"),
                new Frog("FrogWhite", 8, "male")
            };

            // Call methods about dogs
            Console.WriteLine("Average age of dogs are: " + Animal.AverageAge(dogs));
            dogs[2].Sound();
            dogs[1].Sound();
            dogs[3].Sound();
            dogs[0].Sound();

            Console.WriteLine();

            // Call methods about cats
            Console.WriteLine("Average age of cats are " + Animal.AverageAge(cats));
            cats[0].Sound();
            cats[3].Sound();
            tomCat.Sound();
            kitten.Sound();

            Console.WriteLine();

            // Call methods about frogs
            Console.WriteLine("Average age of frogs are: " + Animal.AverageAge(frogs));
            frogs[3].Sound();
            frogs[0].Sound();
            frogs[1].Sound();
            frogs[2].Sound();

            Console.ReadKey();

            #endregion Exerises-4
        }

        #region Exerises-2

        private static void SortStudentByGrade(IEnumerable<Student> studentsList)
        {
            var sortedList =
                from stud in studentsList
                orderby stud.Grade ascending
                select stud;

            // Print sorted students
            Console.WriteLine("==============THIS IS STUDENTS ==============");
            foreach (var item in sortedList)
            {
                Console.WriteLine("Full name: {0}, Grade: {1}", item.FirstName + " " + item.LastName, item.Grade);
            }

            Console.WriteLine();
        }

        // Sort workers by money per hours
        private static void SortWorkersByMoneyPerHours(IEnumerable<Worker> workersList)
        {
            var sortedList = workersList.OrderByDescending(x => x.MoneyPerHour());

            // Print workers
            Console.WriteLine("============== THIS IS WORKERS ==============");
            foreach (var item in sortedList)
            {
                Console.WriteLine("Full name: {0}", item.FirstName + " " + item.LastName);
                Console.WriteLine("Week salary: " + item.WeekSalary);
                Console.WriteLine("Work hours per day: " + item.WorkHoursPerDay);
                Console.WriteLine("Money per hours: " + item.MoneyPerHour());
                Console.ReadKey();
            }
        }

        // Sort merged list by first name and last name
        private static void SortMergedList(IEnumerable<Human> mergedList)
        {
            var sortedList =
                from merge in mergedList
                orderby merge.FirstName, merge.LastName
                select merge;

            // Print merged list
            Console.WriteLine("============== THIS IS MERGED LIST ==============");
            foreach (var item in sortedList)
            {
                Console.WriteLine("First name: {0}, Last name: {1}", item.FirstName, item.LastName);
                Console.ReadKey();
            }
        }

        #endregion Exerises-2
    }
}