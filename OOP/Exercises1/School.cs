using System;
using System.Collections.Generic;

namespace OOP.Exercises1
{
    public class School
    {
        // Fields
        private string schoolName;

        private List<Class> classes;

        //Constructor
        public School(List<Class> classes, string schoolName)
        {
            this.classes = classes;
            this.schoolName = schoolName;
        }

        // Properties
        public string SchoolName
        {
            get { return schoolName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"School name cannot be null!");
                }
                else
                {
                    schoolName = value;
                }
            }
        }

        public List<Class> Classes
        {
            get { return classes; }
            set {
                if (value == null)
                {
                    throw new ArgumentNullException($"Classes name cannot be null!");
                }
                else
                {
                    classes = value;
                }
            }
        }
    }
}