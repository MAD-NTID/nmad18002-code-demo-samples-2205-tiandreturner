using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingOnOOP
{
    class Course
    {
        private string courseNumber;

        public string CourseNumber
        {
            get { return courseNumber; }
            set { courseNumber = value; }
        }

        private string courseName;
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        private string instructor;
        public string Instructor
        {
            get { return instructor; }
            set { instructor = value; }
        }
        private int courseStudents;

        public int CourseStudents
        {
            get { return courseStudents; }
            set { 
                courseStudents = value;
                totalStudents += value;
            }
        }

        private int credits;
        public int Credits
        {
            get { return credits; }
            set {
                if (value < 0)
                    credits = 0;
                else
                {
                    if(value <= 25 && value >= 0)
                    {
                        credits = value;
                    }
                    else if(value <= 0 || value >= 25)
                    {
                        credits = 0;
                    }
                }
            }
        }

        private static int totalStudents;
        public int TotalStudents 
        {
           get { return totalStudents; }
        }

        // overloaded constructors
        public Course()
        {
            CourseNumber = "Unknown";
            CourseName = "Unknown";
            Instructor = "N/A";
            CourseStudents = 0;
        }

        public Course(string courseNumber, string courseName)
        {
            CourseNumber = courseNumber;
            CourseName = courseName;
            Instructor = "N/A";
            CourseStudents = 0;
        }

        public Course(string courseNumber, string courseName, string instructor, int courseStudents)
        {
            CourseNumber = courseNumber;
            CourseName = courseName;
            Instructor = instructor;
            CourseStudents = courseStudents;
        }

        // overloaded methods (examples)
        public void Add(int number)
        {

        }

        public void Add(double number)
        {

        }

        //// setters/mutators
        //public void SetCourseNumber(string _courseNumber)
        //{
        //    courseNumber = _courseNumber;
        //}

        //// getters
        //public string GetCourseNumber()
        //{
        //    return courseNumber;
        //}

        public override string ToString()
        {
            return $"Course Name:     {CourseName}\n" +
                   $"Course Number:   {CourseNumber}\n" +
                   $"Instructor:      {Instructor}\n" +
                   $"# of Students:   {CourseStudents}\n" +
                   $"Credits:         {Credits}\n" +
                   $"Total Students:  {TotalStudents}\n\n";
        }
    }
}
