using System;
using System.Collections.Generic;

namespace OOP.Exercises1
{
    public class Class : Comment
    {
        private string classId;

        /// <summary>
        /// Constructor students
        /// </summary>
        /// <param name="students"></param>
        /// <param name="teachers"></param>
        /// <param name="classId"></param>
        public Class(List<Students> students, List<Teachers> teachers, string classId)
        {
            Students = students;
            Teachers = teachers;
            ClassId = classId;
        }

        /// <summary>
        /// Properties Students
        /// </summary>
        public List<Students> Students { get; set; }

        /// <summary>
        /// Teachers
        /// </summary>
        public List<Teachers> Teachers { get; set; }

        public string ClassId
        {
            get { return this.classId; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"Class ID cannot be null!");
                }
                else
                {
                    this.classId = value;
                }
            }
        }

        // Methods
        // Overrider ToString()
        public override string ToString()
        {
            // Print information about students
            Console.WriteLine("Student: ");
            foreach (var element in Students)
            {
                Console.WriteLine("Full name: {0}, Class: {1}, ClassID: {2}", element.FirstName + " " + element.LastName, element.StudentClassNumber, ClassId);
            }
            Console.WriteLine();

            // Print information about teachers
            Console.WriteLine("Teacher: ");
            foreach (var element in Teachers)
            {
                Console.WriteLine("Full name: {0} \n\nDisciplines: ", element.FirstName + " " + element.LastName);

                foreach (var item in element.Discipline)
                {
                    Console.WriteLine("Discipline name: " + item.DisciplineName);
                    Console.WriteLine("Number of lectures: " + item.NumberOfLectures);
                    Console.WriteLine("Number of exercises: " + item.NumberOfExercises);
                    Console.WriteLine();
                }
            }

            return base.ToString();
        }
    }
}