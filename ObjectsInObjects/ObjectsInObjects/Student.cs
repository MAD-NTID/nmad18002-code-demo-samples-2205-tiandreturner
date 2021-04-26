using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsInObjects
{
    class Student
    {
        private List<Course> courses = new List<Course>();
       // private Dictionary<string, Course> coursesDict = new Dictionary<string, Course>(); 

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string YearLevel { get; set; }

        public List<Course> Courses
        {
            get
            {
                return courses;
            }
            set
            {
                courses = value;
            }
        }

        public int Age { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public Student(string _firstName, string _lastName, int _age, string _yearLevel, List<Course> _courses)
        {
            FirstName = _firstName;
            LastName = _lastName;
            Age = _age;
            YearLevel = _yearLevel;
            Courses = _courses;
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}\nYear Level: {YearLevel}";
        }

        public string GetCourses()
        {
            string coursesStr = "";

            foreach (Course course in courses)
                coursesStr += $"{course}\n";

            return coursesStr;
        }
    }
}
